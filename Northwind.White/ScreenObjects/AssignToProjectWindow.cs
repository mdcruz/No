using Northwind.White.Helpers;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace Northwind.White.ScreenObjects
{
    public class AssignToProjectWindow : WindowObject
    {
        #region Screen objects

        private Button OKBtnEmployeeProjectWindow
        {
            get
            {
                return Button("OK");
            }
        }

        private ListItem TestProject
        {
            get
            {
                return ListItem("Test Project");
            }
        }

        private ComboBox TestRole
        {
            get
            {
                return ComboBox();
            }
        }

        private CheckBox MainProject
        {
            get
            {
                return CheckBox();
            }
        }

        #endregion

        public AssignToProjectWindow(Window window) : base(window)
        {

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
