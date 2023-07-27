using System;


namespace R5T.L0050.L001
{
    public static class Instances
    {
        public static IDirectoryNames DirectoryNames => L001.DirectoryNames.Instance;
        public static F0124.IPathOperator PathOperator => F0124.PathOperator.Instance;
        public static Extensions.IStringOperator StringOperator_Extensions => Extensions.StringOperator.Instance;
        public static F0124.IValues Values => F0124.Values.Instance;
    }
}