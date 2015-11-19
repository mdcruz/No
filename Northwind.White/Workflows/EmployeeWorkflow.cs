using Northwind.White.Helpers;
using Northwind.White.ScreenObjects;
using Northwind.White.TestData;
using TestStack.White;

namespace Northwind.White.Workflows
{
    public class EmployeeWorkflow
    {
        public static void AddNewEmployee(Windows window, EmployeeDetails employeeDetails) 
        {
            window.MainWindow.AddEmployee();
            window.NewEmployeeWindow.AddNewEmployee(employeeDetails);
            window.AssignDepartmentEmployeeWindow.AssignToDepartment(new DepartmentDetails().TestDepartmentName);
            window.NewEmployeeWindow.ClickOk();
        }

        public static void AddNewEmployeeAndLinkToProject(Windows window, EmployeeDetails employeeDetails) 
        {
            window.MainWindow.AddEmployee();
            window.NewEmployeeWindow.AddNewEmployee(employeeDetails);
            window.AssignDepartmentEmployeeWindow.AssignToDepartment(new DepartmentDetails().TestDepartmentName);
            window.NewEmployeeWindow.ClickOk();
            window.EmployeeRecordWindow.AssignEmployeeToProject();
            window.EmployeeProjectRecordWindow.FillInProjectDetails();
            window.EmployeeRecordWindow.ClickOk();
        }
    }
}
