using System;

using R5T.T0132;


namespace R5T.L0050.L001.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IDropboxDirectoryPath"/>
        public IDropboxDirectoryPath ToDropboxDirectoryPath(string value)
        {
            var output = new DropboxDirectoryPath(value);
            return output;
        }
    }
}
