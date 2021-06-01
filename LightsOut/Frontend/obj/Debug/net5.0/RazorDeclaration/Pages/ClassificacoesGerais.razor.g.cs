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
#line 3 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\Pages\ClassificacoesGerais.razor"
using LightsOut.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/classificacoesGerais")]
    public partial class ClassificacoesGerais : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 745 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\Pages\ClassificacoesGerais.razor"
       
    private Resultado resultado = new Resultado();
    private List<Tuple<string, int>> total = new List<Tuple<string, int>>();
    private List<Tuple<string, int>> totalEquipas = new List<Tuple<string, int>>();
    private int provaPretendida = 1;
    private int epocaPretendida = 2019;

    private void ProxProva()
    {
        if (provaPretendida < 22)
        {
            provaPretendida++;
        }
    }

    private void PrevProva()
    {
        if (provaPretendida > 1)
        {
            provaPretendida--;
        }
    }

    private void ProxEpoca()
    {
        if (epocaPretendida < 2021)
        {
            epocaPretendida++;
            provaPretendida = 1;
        }
    }

    private void PrevEpoca()
    {
        if (epocaPretendida > 1999)
        {
            epocaPretendida--;
            provaPretendida = 1;
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {

        if (firstRender)
        {
            total = await resultado.ClassificacoesGeraisPiloto(epocaPretendida, provaPretendida);
            totalEquipas = await resultado.ClassificacoesGeraisEquipas(epocaPretendida, provaPretendida);
            StateHasChanged();
            //Console.WriteLine("sada");
        }
        else
        {
            total = await resultado.ClassificacoesGeraisPiloto(epocaPretendida, provaPretendida);
            totalEquipas = await resultado.ClassificacoesGeraisEquipas(epocaPretendida, provaPretendida);
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PilotoService PilotoService { get; set; }
    }
}
#pragma warning restore 1591
