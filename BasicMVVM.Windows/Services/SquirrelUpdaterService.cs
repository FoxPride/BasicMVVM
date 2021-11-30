﻿using System;
using System.Threading.Tasks;
using BasicMVVM.Core.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Squirrel;

namespace BasicMVVM.Windows.Services
{
    /// <summary>
    ///     Updater service with <see href="https://github.com/Squirrel/Squirrel.Windows">squirrel library</see>.
    /// </summary>
    public class SquirrelUpdaterService : IUpdater
    {
        /// <summary>
        ///     Gets the <see cref="IConfiguration" /> instance to use.
        /// </summary>
        private readonly IConfiguration _config;

        private static string _updateUrl;

        public SquirrelUpdaterService(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        ///     Initialization of updater.
        /// </summary>
        public void StartActions()
        {
            _updateUrl = _config.GetValue<string>("ConnectionStrings:UpdateUrl");

            SquirrelAwareApp.HandleEvents(
                onInitialInstall: OnInstall,
                onAppUpdate: OnUpdate,
                onAppUninstall: OnUninstall);
        }

        /// <summary>
        ///     Checks for updates of the app.
        /// </summary>
        public async Task CheckForUpdate()
        {
            using var mgr = new UpdateManager(_updateUrl);
            var newVersion = await mgr.UpdateApp();

            // optionally restart the app automatically, or ask the user if/when they want to restart
            if (newVersion != null)
            {
                await UpdateManager.RestartAppWhenExited();
            }
        }

        private static void OnInstall(Version obj)
        {
            using var mgr = new UpdateManager(_updateUrl);
            mgr.CreateUninstallerRegistryEntry();
            mgr.CreateShortcutForThisExe();
        }

        private static void OnUpdate(Version obj)
        {
            using var mgr = new UpdateManager(_updateUrl);
            mgr.CreateShortcutForThisExe();
        }

        private static void OnUninstall(Version obj)
        {
            using var mgr = new UpdateManager(_updateUrl);
            mgr.RemoveShortcutForThisExe();
            mgr.RemoveUninstallerRegistryEntry();
        }
    }
}