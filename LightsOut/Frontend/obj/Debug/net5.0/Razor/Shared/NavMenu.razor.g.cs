#pragma checksum "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86fe0657b3e6f401bb372ea105696e6b0c8e28f6"
// <auto-generated/>
#pragma warning disable 1591
namespace LightsOut.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\_Imports.razor"
using LightsOut;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\_Imports.razor"
using LightsOut.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\Shared\NavMenu.razor"
using LightsOut.Data;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-black mb-3 fixed-top");
            __builder.AddAttribute(2, "b-2ckyjn3pwu");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddAttribute(5, "b-2ckyjn3pwu");
            __builder.AddMarkupContent(6, "<a class=\"navbar-brand\" href Match=\"NavLinkMatch.All\" b-2ckyjn3pwu><img src=\"1.png\" b-2ckyjn3pwu></a>\r\n\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", (
#nullable restore
#line 13 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\Shared\NavMenu.razor"
                     NavMenuCssClass

#line default
#line hidden
#nullable disable
            ) + " navbar-collapse" + " d-sm-inline-flex" + " flex-sm-row-reverse");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\Shared\NavMenu.razor"
                                                                                                     CollapseNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "b-2ckyjn3pwu");
            __builder.OpenElement(11, "ul");
            __builder.AddAttribute(12, "class", "navbar-nav flex-grow-1");
            __builder.AddAttribute(13, "b-2ckyjn3pwu");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(14);
            __builder.AddAttribute(15, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "<li class=\"nav-item\" b-2ckyjn3pwu><a href=\"mapaProvas\" b-2ckyjn3pwu>Mapa de Provas</a></li>\r\n                        ");
                __builder2.AddMarkupContent(17, "<li class=\"nav-item\" b-2ckyjn3pwu><a href=\"classificacoesGerais\" b-2ckyjn3pwu>Classificações Gerais</a></li>\r\n                        ");
                __builder2.AddMarkupContent(18, "<li class=\"nav-item\" b-2ckyjn3pwu><a href=\"equipasepilotos\" b-2ckyjn3pwu>Equipas e Pilotos</a></li>\r\n                        ");
                __builder2.OpenElement(19, "li");
                __builder2.AddAttribute(20, "class", "nav-item");
                __builder2.AddAttribute(21, "b-2ckyjn3pwu");
                __builder2.OpenElement(22, "a");
                __builder2.AddAttribute(23, "href", "/");
                __builder2.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\Shared\NavMenu.razor"
                                                  (() => Logout())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "b-2ckyjn3pwu");
                __builder2.AddContent(26, "Log Out");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(27, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(28, "<li class=\"nav-item\" b-2ckyjn3pwu><a href=\"mapaProvas\" b-2ckyjn3pwu>Mapa de Provas</a></li>\r\n                        ");
                __builder2.AddMarkupContent(29, "<li class=\"nav-item\" b-2ckyjn3pwu><a href=\"classificacoesGerais\" b-2ckyjn3pwu>Classificações Gerais</a></li>\r\n                        ");
                __builder2.AddMarkupContent(30, "<li class=\"nav-item\" b-2ckyjn3pwu><a href=\"equipasepilotos\" b-2ckyjn3pwu>Equipas e Pilotos</a></li>\r\n                        ");
                __builder2.AddMarkupContent(31, "<li class=\"nav-item\" b-2ckyjn3pwu><a href=\"login\" b-2ckyjn3pwu>Login</a></li>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    void CollapseNavMenu()
    {
        collapseNavMenu = true;
    }

    public void Logout()
    {
        ((CustomAuthenticationStateProvider)AuthenticationStateProvider).MarkUserAsLoggedOut();
        if (PageHistoryState.CanGoBack()){
            NavigationManager.NavigateTo(PageHistoryState.GetGoBackPage());
        }
        
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PageHistoryState PageHistoryState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
