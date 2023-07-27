using System;

using R5T.T0131;
using R5T.T0180;
using R5T.T0180.Extensions;


namespace R5T.L0050.L001
{
    [ValuesMarker]
    public partial interface IDirectoryNames : IValuesMarker
    {
        public IDirectoryName Dropbox => "Dropbox".ToDirectoryName();
    }
}
