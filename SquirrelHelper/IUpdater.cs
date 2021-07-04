using System.Threading.Tasks;

namespace SquirrelHelper
{
    /// <summary>
    ///     The updater interface.
    /// </summary>
    public interface IUpdater
    {
        /// <summary>
        ///     Method to check for updates of the app.
        /// </summary>
        Task CheckUpdates();
    }
}