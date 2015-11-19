using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace Northwind.White.ScreenObjects
{
    public class AssignToDepartmentWindow
    {
        private Window _window;
 
        private ListItem TestDepartment
        {
            get
            {
                return _window.Get<ListBox>().Item("Test Department");
            }
        }

        private Button OK_ChangeDepartment
        {
            get
            {
                return _window.Get<Button>(SearchCriteria.ByText("OK"));
            }
        }

        public AssignToDepartmentWindow(Window window) 
        {
            _window = window;
        }

        public AssignToDepartmentWindow AssignToDepartment(string departmentName)
        {
            TestDepartment.Click();
            OK_ChangeDepartment.Click();

            return this;
        }
    }
}
