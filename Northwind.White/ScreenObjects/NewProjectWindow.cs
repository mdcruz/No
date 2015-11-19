using Northwind.White.TestData;
using System;
using System.Linq;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Utility;

namespace Northwind.White.ScreenObjects
{
    public class NewProjectWindow
    {
        private Window _window;
        private Application _application;

        #region Screen properties
        private TextBox ProjectName 
        {
            get 
            {
                return _window.Get<TextBox>(SearchCriteria.Indexed(0));
            }
        }

        private TextBox Price 
        {
            get 
            {
                return _window.Get<TextBox>(SearchCriteria.Indexed(1));
            }
        }

        private Button OK_ProjectWindow 
        {
            get 
            {
                return _window.Get<Button>(SearchCriteria.ByText("OK"));
            }
        }

        #endregion

        public NewProjectWindow(Window window) 
        {
            _window = window;
        }

        public void AddNewProject(ProjectDetails details) 
        {
            ProjectName.Text = details.ProjectName;
            Price.Text = details.Price;
            OK_ProjectWindow.Click();
        }
    }
}
