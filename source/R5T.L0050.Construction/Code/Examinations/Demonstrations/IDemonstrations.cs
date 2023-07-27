using System;

using R5T.T0141;


namespace R5T.L0050.Construction
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        // See R5T.S0092.IDemonstrations.
        public void Get_DropboxDirectoryPath()
        {
            var dropboxDirectoryPath = Instances.DropboxDirectoryPathOperator.Get_DropboxDirectoryPath();

            Console.WriteLine(dropboxDirectoryPath);
        }
    }
}
