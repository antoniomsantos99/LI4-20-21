// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LightsOut.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\_Imports.razor"
using LightsOut;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\_Imports.razor"
using LightsOut.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\Pages\LoginPage.razor"
using LightsOut.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\Pages\LoginPage.razor"
using Append.Blazor.Notifications;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class LoginPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\Pages\LoginPage.razor"
      
    private string username = "";
    private string password = "";
    private Utilizador u = new Utilizador();
    
    public void cenas(){
        Console.WriteLine(username);
    }
    
    public void cenasPass(){
        Console.WriteLine(password);
    }

    public async void addUser()
    {
        await NotificationService.RequestPermissionAsync();
        if (u.addUserBaseDados(username, password))
        {
            Console.WriteLine("User Added");
            NavigationManager.NavigateTo("http://localhost:5000");
        }
        else
        {
            Console.WriteLine("Error");
            await NotificationService.CreateAsync("Login Error", "Username já existe!", "images/github.png");
        }


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591