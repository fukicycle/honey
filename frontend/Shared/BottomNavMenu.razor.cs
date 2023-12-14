using Microsoft.AspNetCore.Components;

namespace frontend.Shared
{
    public partial class BottomNavMenu
    {
        private int _selectedIndex = 0;

        [Parameter]
        public EventCallback<int> MenuSelectionChanged { get; set; }

        private async void MenuButtonOnClick(int index)
        {
            _selectedIndex = index;
            await MenuSelectionChanged.InvokeAsync(_selectedIndex);
        }
    }
}