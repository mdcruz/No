using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace Northwind.White.ScreenObjects
{
    public class MainWindow
    {
        private Window _window;

        #region Screen properties

        private ListItem DashboardTab
        {
            get
            {
                return _window.Get<ListBox>().Item("Dashboard");
            }
        }

        private ListItem EmployeesTab 
        {
            get 
            {
                return _window.Get<ListBox>().Item("Employees");
            }
        }

        private ListItem DepartmentsTab 
        {
            get 
            {
                return _window.Get<ListBox>().Item("Departments");
            }
        }

        private ListItem ProjectsTab 
        {
            get 
            {
                return _window.Get<ListBox>().Item("Projects");
            }
        }

        private Button Add 
        {
            get 
            {
                return _window.Get<Button>(SearchCriteria.ByText("Add"));
            }
        }

        private ListView DataList
        {
            get 
            {
                return _window.Get<ListView>();
            }
        }

        #endregion

        public MainWindow(Window window) 
        {
            _window = window;
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
