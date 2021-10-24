using System;
using System.Threading.Tasks;
using BasicMVVM.Core.Services.Interfaces;
using Squirrel;

namespace BasicMVVM.Core.Services
{
    /// <summary>
    ///     Updater service with squirrel library.
    /// </summary>
    public class SquirrelUpdaterService : IUpdater
    {
        private const string UpdateUrl = @"https://the.place/you-host/updates"; //todo get from appsettings

        /// <summary>
        ///     Initialization of updater.
        /// </summary>
        public void StartActions()
        {
            SquirrelAwareApp.HandleEvents(
                onInitialInstall: OnInstall,
                onAppUpdate: OnUpdate,
                onAppUninstall: OnUninstall,
                onFirstRun: OnFirstRun);
        }

        /// <summary>
        ///     Checks for updates.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public async Task CheckForUpdate()
        {
            using var mgr = new UpdateManager(UpdateUrl);
            var newVersion = await mgr.UpdateApp();

            // optionally restart the app automatically, or ask the user if/when they want to restart
            if (newVersion != null)
            {
                UpdateManager.RestartApp();
            }
        }

        private static void OnInstall(Version obj)
        {
            using var mgr = new UpdateManager(UpdateUrl);
            mgr.CreateUninstallerRegistryEntry();
            mgr.CreateShortcutForThisExe();
        }

        private static void OnUpdate(Version obj)
        {
            using var mgr = new UpdateManager(UpdateUrl);
            mgr.CreateShortcutForThisExe();
        }

        private static void OnUninstall(Version obj)
        {
            using var mgr = new UpdateManager(UpdateUrl);
            mgr.RemoveShortcutForThisExe();
            mgr.RemoveUninstallerRegistryEntry();
        }

        private static void OnFirstRun()
        {
            //todo show welcome window
        }
    }
}
