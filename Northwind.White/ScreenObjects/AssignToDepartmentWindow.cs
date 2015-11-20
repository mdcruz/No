using Northwind.White.Helpers;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace Northwind.White.ScreenObjects
{
    public class AssignToDepartmentWindow : WindowObject
    {
        #region Screen properties

        private ListItem TestDepartment
        {
            get
            {
                return ListItem("Test Department");
            }
        }

        private Button OK_ChangeDepartment
        {
            get
            {
                return Button("OK");
            }
        }

        #endregion

        public AssignToDepartmentWindow(Window window) : base(window)
        {

        }

        public AssignToDepartmentWindow AssignToDepartment(string departmentName)
        {
            TestDepartment.Click();
            OK_ChangeDepartment.Click();

            return this;
        }
    }
}
