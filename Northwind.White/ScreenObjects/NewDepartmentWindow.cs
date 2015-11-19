using System;
using System.Linq;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Utility;

namespace Northwind.White
{
    public class NewDepartmentWindow
    {
        private Window _window;

        #region Screen properties

        private TextBox NameField 
        {
            get 
            {
                return _window.Get<TextBox>(SearchCriteria.Indexed(0));
            }
        }

        private Button OK 
        {
            get 
            {
                return _window.Get<Button>(SearchCriteria.ByText("OK"));
            }
        }

        #endregion

        public NewDepartmentWindow(Window window) 
        {
            _window = window;
        }

        public void AddNewDepartment(string departmentName)
        {
            NameField.Text = departmentName;
            OK.Click();
        }
    }
}
