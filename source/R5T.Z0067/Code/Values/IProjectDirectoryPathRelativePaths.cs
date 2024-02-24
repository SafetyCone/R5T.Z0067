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
        /// <para><value>Code\Documentation.cs</value></para>
        /// </summary>
        public string Documentation_cs => @"Code\Documentation.cs";

        /// <summary>
        /// <para><value>Code\Instances.cs</value></para>
        /// </summary>
        public string Instances_cs => @"Code\Instances.cs";

        /// <summary>
        /// <para><value>Code\Program.cs</value></para>
        /// </summary>
        public string Program_cs => @"Code\Program.cs";

        /// <summary>
        /// <para><value>Project Plan.md</value></para>
        /// </summary>
        public string Project_Plan_md => @"Project Plan.md";
    }
}
