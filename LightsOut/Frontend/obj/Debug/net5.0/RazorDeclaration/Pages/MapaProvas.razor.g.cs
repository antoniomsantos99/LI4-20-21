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
#line 3 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\Pages\MapaProvas.razor"
using LightsOut.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\Pages\MapaProvas.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\Pages\MapaProvas.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\Pages\MapaProvas.razor"
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
#line 37 "D:\DEV\GitHub projects\LI4-20-21\LightsOut\Frontend\Pages\MapaProvas.razor"
       
    //private DateTime dia = DateTime.Parse("2019-03-14");
    private DateTime diaInicial = DateTime.Now;
    private DateTime diaFinal = DateTime.Now;
    private int range = 1;
    private Prova prova = new Prova();
    private List<Prova> provas = new List<Prova>();
    private Localizacao local = new Localizacao();
    private List<Localizacao> localizacoes = new List<Localizacao>();
    private List<List<float>> locais = new List<List<float>>();
    //private string tempoRefrescamento = "2";

    
    private void IncrementRange(){
        int i = range+1;
        range = i;
    }

    private void DecrementRange(){
        if (range > 1){
            int i = range-1;
            range = i;
        }
    }

    private void ProxDiaInicial(){
        DateTime d = diaInicial.AddDays(range);
        if (d <= diaFinal){
            diaInicial = d;
            base.StateHasChanged();
        }else{
            diaInicial = diaFinal;
            base.StateHasChanged();
        }
    }

    private void ProxDiaFinal(){
        DateTime d = diaFinal.AddDays(range);
        diaFinal = d;
        base.StateHasChanged();
    }


    protected void PrevDiaInicial(){
        DateTime d = diaInicial.AddDays(-range);
        diaInicial = d;
        base.StateHasChanged();
    }

    protected void PrevDiaFinal(){
        DateTime d = diaFinal.AddDays(-range);
        if (d >= diaInicial){
            diaFinal = d;
            base.StateHasChanged();
        }
        else{
            diaFinal = diaInicial;
            base.StateHasChanged();
        }
    }

    protected List<List<float>> getCoord(List<Prova> provas){
        List<List<float>> result = new List<List<float>>();

        foreach (Prova prova in provas){
            List<float> coord = new List<float>();
            coord.Add(prova.localizacao.latitude);
            coord.Add(prova.localizacao.longitude);
            result.Add(coord);
        }
        
        return result;
    }
    
    protected List<string> getNomes(List<Prova> provas){
        List<string> result = new List<string>();

        foreach (Prova prova in provas){
            result.Add(prova.id);
        }
        
        return result;
    }
    
    protected override async Task OnAfterRenderAsync(bool firstRender) {

        if (firstRender){
            
            /*
            string rondaText = diaFinal.ToString("MM");
            int ronda = Int32.Parse(rondaText);
            provas = prova.ppppp(2019, ronda);
            
            
            List<string> res = new List<string>();
            foreach (var p in provas)
            {
                res.Add(JsonConvert.SerializeObject(p));
            }
            
            await JSRuntime.InvokeVoidAsync("loadMapScenario", res,diaFinal);
            //StateHasChanged();
            */

            provas = prova.localizacaoProvasIntervalo(diaInicial.ToString("yyyy-MM-dd"), diaFinal.ToString("yyyy-MM-dd"));
            List<string> res = new List<string>();
            
            foreach(var p in provas){
                res.Add(JsonConvert.SerializeObject(p));
            }

            await JSRuntime.InvokeVoidAsync("loadMapScenario", res);

        }
        else{
            /*
            string rondaText = diaFinal.ToString("MM");
            int ronda = Int32.Parse(rondaText);
            provas = prova.ppppp(2019, ronda);
           
            List<string> res = new List<string>();
            foreach (var p in provas)
            {
                res.Add(JsonConvert.SerializeObject(p));
            }
            
            await JSRuntime.InvokeVoidAsync("loadMapScenario", res,diaFinal);
            //StateHasChanged();
            */
            provas = prova.localizacaoProvasIntervalo(diaInicial.ToString("yyyy-MM-dd"), diaFinal.ToString("yyyy-MM-dd"));
            List<string> res = new List<string>();
            
            foreach(var p in provas){
                res.Add(JsonConvert.SerializeObject(p));
            }

            await JSRuntime.InvokeVoidAsync("loadMapScenario", res);

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
