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
        private Application _application;

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

        public NewDepartmentWindow(Application application) 
        {
            _application = application;
            _window = Retry.For(
                () => _application.GetWindows().First(x => x.Title.Contains("New department")), TimeSpan.FromSeconds(5));
        }

        public void AddNewDepartment(string departmentName)
        {
            NameField.Text = departmentName;
            OK.Click();
        }
    }
}
