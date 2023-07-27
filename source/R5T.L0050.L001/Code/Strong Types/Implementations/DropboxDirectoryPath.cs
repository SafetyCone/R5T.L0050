using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0050.L001
{
    /// <inheritdoc cref="IDropboxDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class DropboxDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IDropboxDirectoryPath
    {
        public DropboxDirectoryPath(string value)
            : base(value)
        {
        }
    }
}