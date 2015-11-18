using Northwind.White.ScreenObjects;
using Northwind.White.TestData;
using TestStack.White;

namespace Northwind.White.Workflows
{
    public class ProjectWorkflow
    {
        public static void AddNewProject(MainWindow mainWindow, ProjectDetails projectDetails, Application application) 
        {
            mainWindow.AddProject();
            var newProjectWindow = new NewProjectWindow(application);
            newProjectWindow.AddNewProject(projectDetails);
        }
    }
}
