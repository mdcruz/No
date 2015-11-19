using Northwind.White.ScreenObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Utility;

namespace Northwind.White.Helpers
{
    public class Windows
    {
        private Application _application;

        #region Window properties

        public MainWindow MainWindow 
        {
            get 
            {
                return new MainWindow(GetWindow("Northwind"));
            }
        }

        public NewDepartmentWindow NewDepartmentWindow 
        {
            get 
            {
                return new NewDepartmentWindow(GetWindow("New department"));
            }
        }

        public NewEmployeeWindow NewEmployeeWindow
        {
            get
            {
                return new NewEmployeeWindow(GetWindow("New employee"));
            }
        }

        public AssignToDepartmentWindow AssignDepartmentEmployeeWindow
        {
            get
            {
                return new AssignToDepartmentWindow(GetWindow("Change department"));
            }
        }

        public NewProjectWindow NewProjectWindow
        {
            get
            {
                return new NewProjectWindow(GetWindow("New project"));
            }
        }

        public EmployeeRecordWindow EmployeeRecordWindow
        {
            get
            {
                return new EmployeeRecordWindow(GetWindow("Employee:"));
            }
        }

        public AssignToProjectWindow EmployeeProjectRecordWindow
        {
            get
            {
                return new AssignToProjectWindow(GetWindow("New project for employee:"));
            }
        }

        #endregion

        public void Initialise(Application application) 
        {
            _application = application;
        }

        private Window GetWindow(string windowName) 
        {
            return Retry.For(
                () => _application.GetWindows().First(x => x.Title.Contains(windowName)), TimeSpan.FromSeconds(5));
        }
    }
}
