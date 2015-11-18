using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.Database;
using Northwind.White.ScreenObjects;
using Northwind.White.TestData;
using Northwind.White.Workflows;
using System.Configuration;
using TestStack.White;

namespace Northwind.White
{
    [TestClass]
    public class WhiteTests
    {
        private Application application;
        private MainWindow mainWindow;

        [TestInitialize]
        public void Setup() 
        {
            application = Application.Launch(ConfigurationManager.AppSettings["NorthwindApp"]);
            mainWindow = new MainWindow(application);
        }

        [TestMethod]
        public void ShouldAddANewDepartment()
        {
            var departmentDetails = new DepartmentDetails();
            DepartmentWorkflow.AddNewDepartment(mainWindow, departmentDetails, application);
            Assert.IsTrue(mainWindow.IsDepartmentAdded(departmentDetails.DepartmentName), "Department has been added");

            DBQueries.DeleteDepartmentRecord(mainWindow.GetDepartmentName());
        }

        [TestMethod]
        public void ShouldAddANewEmployee() 
        {
            var employeeDetails = new EmployeeDetails();
            EmployeeWorkflow.AddNewEmployee(mainWindow, employeeDetails, application);
            Assert.IsTrue(mainWindow.IsEmployeeAdded(employeeDetails.FirstName, employeeDetails.LastName), "Employee has been added");

            DBQueries.DeleteEmployeeRecord(mainWindow.GetEmployeeFirstName());
        }

        [TestMethod]
        public void ShouldAddANewProject() 
        {
            var projectDetails = new ProjectDetails();
            ProjectWorkflow.AddNewProject(mainWindow, projectDetails, application);
            Assert.IsTrue(mainWindow.IsProjectAdded(projectDetails.ProjectName), "Project has been added");

            DBQueries.DeleteProjectRecord(mainWindow.GetProjectName());
        }

        [TestMethod]
        public void ShouldLinkEmployeeToAProject() 
        {
        
        }
        
        [TestCleanup]
        public void Cleanup() 
        {    
            application.Kill();
        }

    }
}
