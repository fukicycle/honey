using System.Security.Claims;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace frontend.Shared
{
    public partial class Header
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; } = null!;
        [Inject]
        public SignOutSessionStateManager SignOutManager { get; set; } = null!;
        private void UserIconOnClick()
        {
            NavigationManager.NavigateTo("authentication/login");
        }

        private async Task BeginSignOut(MouseEventArgs args)
        {
            await SignOutManager.SetSignOutState();
            NavigationManager.NavigateTo("",true);
        }

        private string GetProfilePicture(AuthenticationState context)
        {
            return context.User.Claims.FirstOrDefault(a => a.Type == "picture")?.Value ?? "";
        }
    }
}