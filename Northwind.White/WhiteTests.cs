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
        }

        [TestMethod]
        public void ShouldAddANewEmployee() 
        {
            var employeeDetails = new EmployeeDetails();
            EmployeeWorkflow.AddNewEmployee(mainWindow, employeeDetails, application);
            Assert.IsTrue(mainWindow.IsEmployeeAdded(employeeDetails.FirstName, employeeDetails.LastName), "Employee has been added");
            Assert.IsFalse(DBQueries.IsEmployeeAddedToProject(employeeDetails.FirstName), "Employee has not been linked to a project"); 
        }

        [TestMethod]
        public void ShouldAddANewProject() 
        {
            var projectDetails = new ProjectDetails();
            ProjectWorkflow.AddNewProject(mainWindow, projectDetails, application);
            Assert.IsTrue(mainWindow.IsProjectAdded(projectDetails.ProjectName), "Project has been added");
        }

        [TestMethod]
        public void ShouldLinkEmployeeToAProject() 
        {
            var projectDetails = new ProjectDetails();
            ProjectWorkflow.AddNewProject(mainWindow, projectDetails, application);

            var employeeDetails = new EmployeeDetails();
            EmployeeWorkflow.AddNewEmployeeAndLinkToProject(mainWindow, employeeDetails, application);
            Assert.IsTrue(DBQueries.IsEmployeeAddedToProject(employeeDetails.FirstName), "Employee has been linked to a project");      
        }
        
        [TestCleanup]
        public void Cleanup() 
        {    
            application.Kill();
            DBQueries.DeleteEmployeeRecord(new EmployeeDetails().FirstName);
            DBQueries.DeleteDepartmentRecord(new DepartmentDetails().DepartmentName);
            DBQueries.DeleteProjectRecord(new ProjectDetails().ProjectName);
        }

    }
}
