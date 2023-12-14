namespace frontend.Pages
{
    public partial class Index
    {
        private int _selectedIndex = 0;
        private void MenuButtonSelectionChanged(int index)
        {
            _selectedIndex = index;
        }
    }
}