using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.Database;
using Northwind.White.Helpers;
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
        private Windows window;
        private EmployeeDetails employeeDetails;
        private DepartmentDetails departmentDetails;
        private ProjectDetails projectDetails;

        [TestInitialize]
        public void Setup() 
        {
            application = Application.Launch(ConfigurationManager.AppSettings["NorthwindApp"]);
            window = new Windows();
            window.Initialise(application);

            employeeDetails = new EmployeeDetails();
            departmentDetails = new DepartmentDetails();
            projectDetails = new ProjectDetails();
        }

        [TestMethod]
        public void ShouldAddANewDepartment()
        {
            DepartmentWorkflow.AddNewDepartment(window, departmentDetails);
            Assert.IsTrue(window.MainWindow.IsDepartmentAdded(departmentDetails.DepartmentName), "Department has been added");
        }

        [TestMethod]
        public void ShouldAddANewEmployee() 
        {
            EmployeeWorkflow.AddNewEmployee(window, employeeDetails);
            Assert.IsTrue(window.MainWindow.IsEmployeeAdded(employeeDetails.FirstName, employeeDetails.LastName), "Employee has been added");
            Assert.IsFalse(DBQueries.IsEmployeeAddedToProject(employeeDetails.FirstName), "Employee has not been linked to a project"); 
        }

        [TestMethod]
        public void ShouldAddANewProject() 
        {
            ProjectWorkflow.AddNewProject(window, projectDetails);
            Assert.IsTrue(window.MainWindow.IsProjectAdded(projectDetails.ProjectName), "Project has been added");
        }

        [TestMethod]
        public void ShouldLinkEmployeeToAProject() 
        {
            ProjectWorkflow.AddNewProject(window, projectDetails);
            EmployeeWorkflow.AddNewEmployeeAndLinkToProject(window, employeeDetails);
            Assert.IsTrue(DBQueries.IsEmployeeAddedToProject(employeeDetails.FirstName), "Employee has been linked to a project");      
        }
        
        [TestCleanup]
        public void Cleanup() 
        {    
            application.Kill();
            DBQueries.DeleteEmployeeRecord(employeeDetails.FirstName);
            DBQueries.DeleteDepartmentRecord(departmentDetails.DepartmentName);
            DBQueries.DeleteProjectRecord(projectDetails.ProjectName);
        }

    }
}
