using Northwind.White.Helpers;
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

        #endregion

        public EmployeeRecordWindow(Window window) 
        {
            _window = window;
        }

        public void AssignEmployeeToProject() 
        {
            ProjectsTab.Select();
            AddBtn.Click();
        }

        public void ClickOk() 
        {
            OKBtn.Click();
        }
    }
}
