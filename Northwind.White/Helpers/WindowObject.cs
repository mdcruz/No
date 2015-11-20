using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace Northwind.White.Helpers
{
    public class WindowObject
    {
        private Window _window;

        public WindowObject(Window window) 
        {
            _window = window;
        }

        public Button Button(string identifier) 
        {
            return _window.Get<Button>(SearchCriteria.ByText(identifier));
        }

        public ListItem ListItem(string identifier) 
        {
            return _window.Get<ListBox>().Item(identifier);
        }

        public ComboBox ComboBox() 
        {
            return _window.Get<ComboBox>();
        }

        public CheckBox CheckBox() 
        {
            return _window.Get<CheckBox>();
        }

        public ListView ListView() 
        {
            return _window.Get<ListView>();
        }

        public TextBox TextBox(int index) 
        {
            return _window.Get<TextBox>(SearchCriteria.Indexed(index));
        }
    }
}
