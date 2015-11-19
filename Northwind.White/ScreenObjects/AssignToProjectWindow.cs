using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace Northwind.White.ScreenObjects
{
    public class AssignToProjectWindow
    {
        private Window _window;

        private Button OKBtnEmployeeProjectWindow
        {
            get
            {
                return _window.Get<Button>(SearchCriteria.ByText("OK"));
            }
        }

        private ListItem TestProject
        {
            get
            {
                return _window.Get<ListBox>().Item("Test Project");
            }
        }

        private ComboBox TestRole
        {
            get
            {
                return _window.Get<ComboBox>();
            }
        }

        private CheckBox MainProject
        {
            get
            {
                return _window.Get<CheckBox>();
            }
        }

        public AssignToProjectWindow(Window window) 
        {
            _window = window;   
        }

        public void FillInProjectDetails() 
        {
            TestProject.Select();
            TestRole.Select("Tester");
            MainProject.Click();
            OKBtnEmployeeProjectWindow.Click();
        }
    }
}
