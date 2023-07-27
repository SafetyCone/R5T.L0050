using System;

using R5T.F0124;
using R5T.T0132;
using R5T.T0180;

using R5T.L0050.L001.Extensions;


namespace R5T.L0050.L001
{
    [FunctionalityMarker]
    public partial interface IDropboxDirectoryPathOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Gets the path to the Dropbox child directory of the parent directory.
        /// </summary>
        public IDropboxDirectoryPath Get_DropboxDirectoryPath(IDirectoryPath parentDirectoryPath,
            bool ensureDirectoryPathIsDirectoryIndicated = IValues.Default_EnsureDirectoryPathIsDirectoryIndicated)
        {
            var output = Instances.PathOperator.Get_DirectoryPath(
                parentDirectoryPath,
                Instances.DirectoryNames.Dropbox,
                x => x.ToDropboxDirectoryPath(),
                ensureDirectoryPathIsDirectoryIndicated)
                ;

            return output;
        }
    }
}
