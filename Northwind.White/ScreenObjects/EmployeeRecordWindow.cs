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
    public class EmployeeRecordWindow : WindowObject
    {
        #region Screen properties

        private Button OKBtn 
        {
            get 
            {
                return Button("OK");
            }
        }

        private Button AddBtn
        {
            get
            {
                return Button("Add");
            }
        }

        private Button CancelBtn 
        {
            get 
            {
                return Button("Cancel");
            }
        }

        private ListItem ProjectsTab 
        {
            get 
            {
                return ListItem("Projects");
            }
        }

        #endregion

        public EmployeeRecordWindow(Window window) : base(window)
        {

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
