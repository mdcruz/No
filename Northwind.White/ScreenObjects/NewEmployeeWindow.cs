using Northwind.White.TestData;
using System;
using System.Linq;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Utility;

namespace Northwind.White.ScreenObjects
{
    public class NewEmployeeWindow
    {
        private Window _window;
        private Window _changeDepartmentWindow;
        private Application _application;

        #region Screen properties

        private Button Change 
        {
            get 
            {
                return _window.Get<Button>(SearchCriteria.ByText("Change"));
            }
        }

        private TextBox FirstName 
        {
            get 
            {
                return _window.Get<TextBox>(SearchCriteria.Indexed(0));
            }
        }

        private TextBox LastName
        {
            get
            {
                return _window.Get<TextBox>(SearchCriteria.Indexed(1));
            }
        }

        private TextBox AboutField
        {
            get
            {
                return _window.Get<TextBox>(SearchCriteria.Indexed(2));
            }
        }

        private ListItem TestDepartment 
        {
            get 
            {
                return _changeDepartmentWindow.Get<ListBox>().Item("Test Department");
            }
        }

        private Button OK_ChangeDepartment 
        {
            get 
            {
                return _changeDepartmentWindow.Get<Button>(SearchCriteria.ByText("OK"));
            }
        }

        private Button OK_EmployeeWindow 
        {
            get 
            {
                return _window.Get<Button>(SearchCriteria.ByText("OK"));
            }
        }

        #endregion

        public NewEmployeeWindow(Application application) 
        {
            _application = application;
            _window = Retry.For(
               () => _application.GetWindows().First(x => x.Title.Contains("New employee")), TimeSpan.FromSeconds(5));
        }

        public NewEmployeeWindow AddNewEmployee(EmployeeDetails details)
        {
            FirstName.Text = details.FirstName;
            LastName.Text = details.LastName;
            AboutField.Text = details.Description;
            Change.Click();

            return this;
        }

        public NewEmployeeWindow AssignToDepartment(string departmentName)
        {
            _changeDepartmentWindow = Retry.For(
                () => _application.GetWindows().First(x => x.Title.Contains("Change department")), TimeSpan.FromSeconds(5));

            TestDepartment.Click();
            OK_ChangeDepartment.Click();
            OK_EmployeeWindow.Click();

            return this;
        }
    }
}
