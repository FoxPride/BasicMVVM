using System.Threading.Tasks;
using Squirrel;

namespace SquirrelHelper
{
    /// <summary>
    ///     The squirrel updater service.
    /// </summary>
    public class SquirrelUpdaterService : IUpdater
    {
        /// <summary>
        ///     Checks for updates.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public async Task CheckUpdates()
        {
            using (var mgr = new UpdateManager("G:\\Andrew\\Programming\\ms-desktop\\Deployment\\Releases"))
            {
                await mgr.UpdateApp();
            }
        }
    }
}
