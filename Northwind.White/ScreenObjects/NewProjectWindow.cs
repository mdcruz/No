using Northwind.White.Helpers;
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
    public class NewProjectWindow : WindowObject
    {
        #region Screen properties

        private TextBox ProjectName 
        {
            get 
            {
                return TextBox(0);
            }
        }

        private TextBox Price 
        {
            get 
            {
                return TextBox(1);
            }
        }

        private Button OK_ProjectWindow 
        {
            get 
            {
                return Button("OK");
            }
        }

        #endregion

        public NewProjectWindow(Window window) : base(window)
        {
      
        }

        public void AddNewProject(ProjectDetails details) 
        {
            ProjectName.Text = details.ProjectName;
            Price.Text = details.Price;
            OK_ProjectWindow.Click();
        }
    }
}
