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
#line 3 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\Pages\EquipasEPilotos.razor"
using LightsOut.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/equipasepilotos")]
    public partial class EquipasEPilotos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\Pages\EquipasEPilotos.razor"
       
    private Equipa[] equipas;
    private int epocaPretendida = 2021;

    private void ProxEpoca()
    {
        epocaPretendida++;
    }

    protected void PrevEpoca()
    {
        if (epocaPretendida >= 1)
        {
            epocaPretendida--;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        equipas = await EquipaService.GetEquipas();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EquipaService EquipaService { get; set; }
    }
}
#pragma warning restore 1591
