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
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>package.json</value></para>
        /// </summary>
        public string package_json => @"package.json";

        /// <summary>
        /// <para><value>Components\Pages\Error.razor</value></para>
        /// </summary>
        public string Error_razor_Page => @"Components\Pages\Error.razor";

        /// <summary>
        /// <para><value>tailwind.config.js</value></para>
        /// </summary>
        public string tailwind_config_js => @"tailwind.config.js";

        /// <summary>
        /// <para><value>source\css\tailwind.css</value></para>
        /// </summary>
        public string tailwind_css => @"source\css\tailwind.css";

        /// <summary>
        /// <para><value>Components\_Imports.razor</value></para>
        /// </summary>
        public string _Imports_razor_ForComponents => @"Components\_Imports.razor";

        /// <summary>
        /// <para><value>Components\Routes.razor</value></para>
        /// </summary>
        public string Routes_razor => @"Components\Routes.razor";

        /// <summary>
        /// <para><value>Components\Layout\MainLayout.razor</value></para>
        /// </summary>
        public string MainLayout_razor => @"Components\Layout\MainLayout.razor";

        /// <summary>
        /// <para><value>Components\Pages\Home.razor</value></para>
        /// </summary>
        public string Home_razor => @"Components\Pages\Home.razor";

        /// <summary>
        /// <para><value>tailwind.contentpaths.json</value></para>
        /// </summary>
        public string tailwind_contentpaths_json => @"tailwind.contentpaths.json";



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
        /// <para><value>Code\Forms\Form1.cs</value></para>
        /// </summary>
        public string Form1_cs => @"Code\Forms\Form1.cs";

        /// <summary>
        /// <para><value>Code\Forms\Form1.Designer.cs</value></para>
        /// </summary>
        public string Form1_Designer_cs => @"Code\Forms\Form1.Designer.cs";

        /// <summary>
        /// <para><value>Code\Forms\Form1.resx</value></para>
        /// </summary>
        public string Form1_resx => @"Code\Forms\Form1.resx";

        /// <summary>
        /// <para><value>Routes\Pages\_Host.cshtml</value></para>
        /// </summary>
        public string _Host_cshtml => @"Routes\Pages\_Host.cshtml";

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

        /// <summary>
        /// <para><value>Controllers\StringsController.cs</value></para>
        /// </summary>
        public string StringsController_cs => @"Controllers\StringsController.cs";

#pragma warning restore IDE1006 // Naming Styles
    }
}
