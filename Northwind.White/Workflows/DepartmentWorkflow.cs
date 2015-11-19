using Northwind.White.Helpers;
using Northwind.White.ScreenObjects;
using Northwind.White.TestData;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace Northwind.White.Workflows
{
    public class DepartmentWorkflow
    {
        public static void AddNewDepartment(Windows window, DepartmentDetails departmentDetails) 
        {
            window.MainWindow.ClickAddDepartment();
            window.NewDepartmentWindow.AddNewDepartment(departmentDetails.DepartmentName);
        }
    }
}
