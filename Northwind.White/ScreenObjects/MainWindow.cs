using Northwind.White.Helpers;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace Northwind.White.ScreenObjects
{
    public class MainWindow : WindowObject
    {
        #region Screen properties

        private ListItem DashboardTab
        {
            get
            {
                return ListItem("Dashboard");
            }
        }

        private ListItem EmployeesTab 
        {
            get 
            {
                return ListItem("Employees");
            }
        }

        private ListItem DepartmentsTab 
        {
            get 
            {
                return ListItem("Departments");
            }
        }

        private ListItem ProjectsTab 
        {
            get 
            {
                return ListItem("Projects");
            }
        }

        private Button Add 
        {
            get 
            {
                return Button("Add");
            }
        }

        private ListView DataList
        {
            get 
            {
                return ListView();
            }
        }

        #endregion

        public MainWindow(Window window) : base(window)
        {
    
        }

        public void AddEmployee()
        {
            EmployeesTab.Select();
            Add.Click();
        }

        public void ClickAddDepartment() 
        {
            DepartmentsTab.Select();
            Add.Click();
        }

        public void AddProject()
        {
            ProjectsTab.Select();
            Add.Click();
        }

        public void ClickEmployeeRecord() 
        {
            DataList.Rows[0].Click();
        }

        public bool IsEmployeeAdded(string firstName, string lastName)
        {
            return GetEmployeeFirstName() == firstName
                && GetEmployeeLastName() == lastName;  
        }

        public bool IsDepartmentAdded(string departmentName) 
        {
            return GetDepartmentName() == departmentName;
        }

        public bool IsProjectAdded(string projectName)
        {
            return GetProjectName() == projectName;
        }

        public string GetEmployeeFirstName() 
        {
            return DataList.Rows[0].Cells["First Name"].Text;
        }

        public string GetEmployeeLastName() 
        {
            return DataList.Rows[0].Cells["Last Name"].Text;
        }

        public string GetDepartmentName() 
        {
            return DataList.Rows[1].Cells["Name"].Text;
        }

        public string GetProjectName()
        {
            return DataList.Rows[0].Cells["Name"].Text;
        }

        
    }
}
