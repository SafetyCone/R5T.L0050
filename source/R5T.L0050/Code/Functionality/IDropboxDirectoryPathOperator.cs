using System;

using R5T.F0124;
using R5T.T0132;

using R5T.L0050.L001;


namespace R5T.L0050
{
    [FunctionalityMarker]
    public partial interface IDropboxDirectoryPathOperator : IFunctionalityMarker,
        L001.IDropboxDirectoryPathOperator
    {
        /// <summary>
        /// Get's the Dropbox directory path (assuming the Dropbox directory is in the current user's user directory).
        /// </summary>
        public IDropboxDirectoryPath Get_DropboxDirectoryPath(
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            var userDirectoryPath = Instances.WindowsSpecialDirectoryPaths.UserProfile;

            var output = this.Get_DropboxDirectoryPath(
                userDirectoryPath,
                ensureDirectoryPathIsDirectoryIndicated);

            return output;
        }
    }
}
