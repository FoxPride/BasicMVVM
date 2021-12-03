using $ext_safeprojectname$.Core.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Squirrel;
using System;
using System.Threading.Tasks;

namespace $ext_safeprojectname$.Windows.Services
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Updater service with <see href="https://github.com/Squirrel/Squirrel.Windows">squirrel
    /// library</see>.
    /// </summary>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class SquirrelUpdaterService : IUpdater
    {
        private readonly IConfiguration _config;

        private static string _updateUrl;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <param name="config">   The configuration. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public SquirrelUpdaterService(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>   Initialization of updater. </summary>
        public void StartActions()
        {
            _updateUrl = _config.GetValue<string>("ConnectionStrings:UpdateUrl");

            SquirrelAwareApp.HandleEvents(
                onInitialInstall: OnInstall,
                onAppUpdate: OnUpdate,
                onAppUninstall: OnUninstall);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Checks for updates of the app. </summary>
        ///
        /// <returns>   The <see cref="Task" />. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

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