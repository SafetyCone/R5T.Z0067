using System;

using R5T.T0131;


namespace R5T.Z0067
{
    /// <summary>
    /// Rivet-convention, general, project directory path-relative paths.
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectDirectoryPathRelativePaths : IValuesMarker,
        Z001.IProjectDirectoryPathRelativePaths
    {
        /// <summary>
        /// <para><value>Code\Program.cs</value></para>
        /// </summary>
        public string Program_cs => @"Code\Program.cs";
    }
}
