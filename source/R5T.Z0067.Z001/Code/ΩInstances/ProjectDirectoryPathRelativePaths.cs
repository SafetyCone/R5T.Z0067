using System;


namespace R5T.Z0067.Z001
{
    public class ProjectDirectoryPathRelativePaths : IProjectDirectoryPathRelativePaths
    {
        #region Infrastructure

        public static IProjectDirectoryPathRelativePaths Instance { get; } = new ProjectDirectoryPathRelativePaths();


        private ProjectDirectoryPathRelativePaths()
        {
        }

        #endregion
    }
}
