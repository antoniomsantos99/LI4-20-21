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
#line 10 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\_Imports.razor"
using LightsOut;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\_Imports.razor"
using LightsOut.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\Pages\MapaProvas.razor"
using LightsOut.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\Pages\MapaProvas.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\Pages\MapaProvas.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\Pages\MapaProvas.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mapaProvas")]
    public partial class MapaProvas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Frontend\Pages\MapaProvas.razor"
       
    private DateTime diaInicial = DateTime.Now;
    private DateTime diaFinal = DateTime.Now;
    private int range = 1;
    //private ProvaMo prova = new Prova();
    private List<ProvaModel> provas = new List<ProvaModel>();
    //private Localizacao local = new Localizacao();
    private List<LocalizacaoModel> localizacoes = new List<LocalizacaoModel>();
    private List<List<float>> locais = new List<List<float>>();
    private String time;


    private void IncrementRange()
    {
        int i = range + 1;
        range = i;
    }

    private void DecrementRange()
    {
        if (range > 1)
        {
            int i = range - 1;
            range = i;
        }
    }

    private void ProxDiaInicial()
    {
        DateTime d = diaInicial.AddDays(range);
        if (d <= diaFinal)
        {
            diaInicial = d;
            base.StateHasChanged();
        }
        else
        {
            diaInicial = diaFinal;
            base.StateHasChanged();
        }
    }

    private void ProxDiaFinal()
    {
        DateTime d = diaFinal.AddDays(range);
        diaFinal = d;
        base.StateHasChanged();
    }


    protected void PrevDiaInicial()
    {
        DateTime d = diaInicial.AddDays(-range);
        diaInicial = d;
        base.StateHasChanged();
    }

    protected void PrevDiaFinal()
    {
        DateTime d = diaFinal.AddDays(-range);
        if (d >= diaInicial)
        {
            diaFinal = d;
            base.StateHasChanged();
        }
        else
        {
            diaFinal = diaInicial;
            base.StateHasChanged();
        }
    }

    protected List<List<float>> getCoord(List<ProvaModel> provas)
    {
        List<List<float>> result = new List<List<float>>();

        foreach (ProvaModel prova in provas)
        {
            List<float> coord = new List<float>();
            coord.Add(prova.localizacao.latitude);
            coord.Add(prova.localizacao.longitude);
            result.Add(coord);
        }

        return result;
    }

    protected List<string> getNomes(List<ProvaModel> provas)
    {
        List<string> result = new List<string>();

        foreach (ProvaModel prova in provas)
        {
            result.Add(prova.id);
        }

        return result;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {

        if (firstRender)
        {
            provas = _dbProva.localizacaoProvasIntervalo(diaInicial.ToString("yyyy-MM-dd"), diaFinal.ToString("yyyy-MM-dd"));
            List<string> res = new List<string>();

            foreach (var p in provas)
            {
                res.Add(JsonConvert.SerializeObject(p));
            }

            await JSRuntime.InvokeVoidAsync("loadMapScenario", res);
            TimerService.UpdateEvent += async date =>
            {
                await InvokeAsync(() =>
                {
                    StateHasChanged();
                });
            };
        }
        else
        {
            provas = _dbProva.localizacaoProvasIntervalo(diaInicial.ToString("yyyy-MM-dd"), diaFinal.ToString("yyyy-MM-dd"));
            List<string> res = new List<string>();

            foreach (var p in provas)
            {
                res.Add(JsonConvert.SerializeObject(p));
            }

            await JSRuntime.InvokeVoidAsync("loadMapScenario", res);

            TimerService.UpdateEvent += async date =>
            {
                await InvokeAsync(() =>
                {
                    time += date;
                    StateHasChanged();
                });
            };

        }

        PageHistoryState.AddPageToHistory("/mapaProvas");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProvaData _dbProva { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalizacaoData _dbLocalizacao { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PageHistoryState PageHistoryState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
