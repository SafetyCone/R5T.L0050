using System;


namespace R5T.L0050.Construction
{
    public class Demonstrations : IDemonstrations
    {
        #region Infrastructure

        public static IDemonstrations Instance { get; } = new Demonstrations();


        private Demonstrations()
        {
        }

        #endregion
    }
}
