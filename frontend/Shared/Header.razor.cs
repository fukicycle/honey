using Microsoft.AspNetCore.Components;

namespace frontend.Shared
{
    public partial class Header
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; } = null!;
        private void UserIconOnClick()
        {
            NavigationManager.NavigateTo("login");
        }
    }
}