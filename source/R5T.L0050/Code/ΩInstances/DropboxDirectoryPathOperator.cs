using System;


namespace R5T.L0050
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
