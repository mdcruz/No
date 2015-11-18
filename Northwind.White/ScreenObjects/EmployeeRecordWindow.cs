using System;
using System.Linq;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Utility;

namespace Northwind.White.ScreenObjects
{
    public class EmployeeRecordWindow
    {
        private Application _application;
        private Window _window;

        #region Screen properties

        public Button OK 
        {
            get 
            {
                return _window.Get<Button>(SearchCriteria.ByText("OK"));
            }
        }
        #endregion

        public EmployeeRecordWindow(Application application) 
        {
            _application = application;
            _window = Retry.For(
                () => _application.GetWindows().First(x => x.Title.Contains("Employee:")), TimeSpan.FromSeconds(5));
        }

        public void ClickOk() 
        {
            OK.Click();
        }
    }
}
