using Northwind.White.Helpers;
using Northwind.White.ScreenObjects;
using Northwind.White.TestData;
using TestStack.White;

namespace Northwind.White.Workflows
{
    public class ProjectWorkflow
    {
        public static void AddNewProject(Windows window, ProjectDetails projectDetails) 
        {
            window.MainWindow.AddProject();
            window.NewProjectWindow.AddNewProject(projectDetails);
        }
    }
}
