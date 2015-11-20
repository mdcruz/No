using Northwind.White.Helpers;
using System;
using System.Linq;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Utility;

namespace Northwind.White
{
    public class NewDepartmentWindow : WindowObject
    {
        #region Screen properties

        private TextBox NameField 
        {
            get 
            {
                return TextBox(0);
            }
        }

        private Button OK 
        {
            get 
            {
                return Button("OK");
            }
        }

        #endregion

        public NewDepartmentWindow(Window window) : base(window)
        {
       
        }

        public void AddNewDepartment(string departmentName)
        {
            NameField.Text = departmentName;
            OK.Click();
        }
    }
}
