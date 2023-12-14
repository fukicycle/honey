using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;

namespace frontend.Pages
{
    public partial class Index
    {

        [Inject]
        public ILocalStorageService LocalStorageService { get; set; } = null!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = null!;
        protected override async Task OnInitializedAsync()
        {
            bool hasUserId = await LocalStorageService.ContainKeyAsync("USER_ID");
            if (!hasUserId)
            {
                // NavigationManager.NavigateTo("login");
            }
        }

        private int _selectedIndex = 0;
        private void MenuButtonSelectionChanged(int index)
        {
            _selectedIndex = index;
        }
    }
}