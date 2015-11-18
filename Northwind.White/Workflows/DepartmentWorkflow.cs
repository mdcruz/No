using Northwind.White.ScreenObjects;
using Northwind.White.TestData;
using TestStack.White;

namespace Northwind.White.Workflows
{
    public class DepartmentWorkflow
    {
        public static void AddNewDepartment(MainWindow mainWindow, DepartmentDetails departmentDetails, Application application) 
        {
            mainWindow.AddDepartment();
            var newDepartmentWindow = new NewDepartmentWindow(application);
            newDepartmentWindow.AddNewDepartment(departmentDetails.DepartmentName);
        }
    }
}
