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
    public class EmployeeRecordWindow
    {
        private Application _application;
        private Window _window;

        #region Screen properties

        private Button OKBtn 
        {
            get 
            {
                return _window.Get<Button>(SearchCriteria.ByText("OK"));
            }
        }

        private Button AddBtn
        {
            get
            {
                return _window.Get<Button>(SearchCriteria.ByText("Add"));
            }
        }

        private Button CancelBtn 
        {
            get 
            {
                return _window.Get<Button>(SearchCriteria.ByText("Cancel"));
            }
        }

        private ListItem ProjectsTab 
        {
            get 
            {
                return _window.Get<ListBox>().Item("Projects");
            }
        }

        private ListItem TestProject
        {
            get
            {
                return EmployeeProjectWindow.Get<ListBox>().Item("Test Project");
            }
        }

        private ComboBox TestRole 
        {
            get 
            {
                return EmployeeProjectWindow.Get<ComboBox>();
            }
        }

        private CheckBox MainProject 
        {
            get 
            {
                return EmployeeProjectWindow.Get<CheckBox>();
            }
        }

        private Button OKBtnEmployeeProjectWindow
        {
            get
            {
                return EmployeeProjectWindow.Get<Button>(SearchCriteria.ByText("OK"));
            }
        }

        private Window EmployeeProjectWindow 
        {
            get 
            {
                return Retry.For(
                    () => _application.GetWindows().First(x => x.Title.Contains("New project for employee:")), TimeSpan.FromSeconds(5));
            }
        }

        #endregion

        public EmployeeRecordWindow(Application application) 
        {
            _application = application;
            _window = Retry.For(
                () => _application.GetWindows().First(x => x.Title.Contains("Employee:")), TimeSpan.FromSeconds(5));
        }

        public void AssignEmployeeToProject() 
        {
            ProjectsTab.Select();
            AddBtn.Click();
            TestProject.Select();
            TestRole.Select("Tester");
            MainProject.Click();
            OKBtnEmployeeProjectWindow.Click();
            OKBtn.Click();
        }
    }
}
