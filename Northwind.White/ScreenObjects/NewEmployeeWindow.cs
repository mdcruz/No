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

        private Button OKBtn
        {
            get 
            {
                return _window.Get<Button>(SearchCriteria.ByText("OK"));
            }
        }

        #endregion

        public NewEmployeeWindow(Window window) 
        {
            _window = window;
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
