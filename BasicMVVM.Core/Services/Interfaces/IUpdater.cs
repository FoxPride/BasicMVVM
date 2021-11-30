using System.Threading.Tasks;

namespace BasicMVVM.Core.Services.Interfaces
{
    /// <summary>   The updater interface. </summary>
    public interface IUpdater
    {
        /// <summary>   Method to init updater. </summary>
        void StartActions();

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Method to check for updates of the app. </summary>
        ///
        /// <returns>   A Task. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        Task CheckForUpdate();
    }
}