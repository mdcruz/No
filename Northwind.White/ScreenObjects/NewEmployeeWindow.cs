using Northwind.White.Helpers;
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
    public class NewEmployeeWindow : WindowObject
    {
        #region Screen properties

        private Button Change 
        {
            get 
            {
                return Button("Change");
            }
        }

        private TextBox FirstName 
        {
            get 
            {
                return TextBox(0);
            }
        }

        private TextBox LastName
        {
            get
            {
                return TextBox(1);
            }
        }

        private TextBox AboutField
        {
            get
            {
                return TextBox(2);
            }
        }

        private Button OKBtn
        {
            get 
            {
                return Button("OK");
            }
        }

        #endregion

        public NewEmployeeWindow(Window window) : base(window)
        {
     
        }

        public NewEmployeeWindow AddNewEmployee(EmployeeDetails details)
        {
            FirstName.Text = details.FirstName;
            LastName.Text = details.LastName;
            AboutField.Text = details.Description;
            Change.Click();

            return this;
        }

        public NewEmployeeWindow ClickOk()
        {
            OKBtn.Click();
            return this;
        }
    }
}
