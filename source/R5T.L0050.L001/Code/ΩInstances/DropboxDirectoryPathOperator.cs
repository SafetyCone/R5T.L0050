using System;


namespace R5T.L0050.L001
{
    public class DropboxDirectoryPathOperator : IDropboxDirectoryPathOperator
    {
        #region Infrastructure

        public static IDropboxDirectoryPathOperator Instance { get; } = new DropboxDirectoryPathOperator();


        private DropboxDirectoryPathOperator()
        {
        }

        #endregion
    }
}
