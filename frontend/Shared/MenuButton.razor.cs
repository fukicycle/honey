using Microsoft.AspNetCore.Components;

namespace frontend.Shared
{
    public partial class MenuButton
    {
        [Parameter]
        public int Type { get; set; }

        [Parameter]
        public bool IsSelected { get; set; }

        [Parameter]
        public EventCallback OnClick { get; set; }
    }
}