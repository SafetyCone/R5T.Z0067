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
        /// <para><value>Components\App.razor</value></para>
        /// </summary>
        public string App_razor => @"Components\App.razor";

        /// <summary>
        /// <para><value>appsettings.json</value></para>
        /// </summary>
        public string AppSettings_json => @"appsettings.json";

        /// <summary>
        /// <para><value>appsettings.Development.json</value></para>
        /// </summary>
        public string AppSettings_Development_json => @"appsettings.Development.json";

        /// <summary>
        /// <para><value>_Types\Classes\Class1.cs</value></para>
        /// </summary>
        public string Class1_cs => @"_Types\Classes\Class1.cs";

        /// <summary>
        /// <para><value>Components\Component1.razor</value></para>
        /// </summary>
        public string Component1_razor => @"Components\Component1.razor";

        /// <summary>
        /// <para><value>Code\Documentation.cs</value></para>
        /// </summary>
        public string Documentation_cs => @"Code\Documentation.cs";

        /// <summary>
        /// <para><value>Routes\Pages\_Host.cshtml</value></para>
        /// </summary>
#pragma warning disable IDE1006 // Naming Styles
        public string _Host_cshtml => @"Routes\Pages\_Host.cshtml";
#pragma warning restore IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>Routes\Components\Index.razor</value></para>
        /// </summary>
        public string Index_razor => @"Routes\Components\Index.razor";

        /// <summary>
        /// <para><value>Code\Instances.cs</value></para>
        /// </summary>
        public string Instances_cs => @"Code\Instances.cs";

        /// <summary>
        /// <para><value>Code\Documentation.cs</value></para>
        /// </summary>
        public string LaunchSettings_json => @"Properties\launchSettings.json";

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
