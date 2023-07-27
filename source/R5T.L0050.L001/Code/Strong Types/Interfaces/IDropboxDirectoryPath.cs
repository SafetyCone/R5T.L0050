using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.L0050.L001
{
    /// <summary>
    /// Strongly-types a string as the path of a Dropbox directory.
    /// </summary>
    [StrongTypeMarker]
    public interface IDropboxDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}