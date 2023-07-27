using System;


namespace R5T.L0050.L001.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToDropboxDirectoryPath(string)"/>
        public static IDropboxDirectoryPath ToDropboxDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToDropboxDirectoryPath(value);
        }
    }
}
