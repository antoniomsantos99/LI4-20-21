#pragma checksum "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Pages\ClassificacoesGerais.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9d461c53887778ffe83ef084ec482d4a427d352"
// <auto-generated/>
#pragma warning disable 1591
namespace LightsOut.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\_Imports.razor"
using LightsOut;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\_Imports.razor"
using LightsOut.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Pages\ClassificacoesGerais.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "classificacoes");
            __builder.AddAttribute(2, "b-52b1hvjf8i");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddAttribute(5, "b-52b1hvjf8i");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "filtros");
            __builder.AddAttribute(8, "b-52b1hvjf8i");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddAttribute(11, "b-52b1hvjf8i");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Pages\ClassificacoesGerais.razor"
                                                PrevEpoca

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "b-52b1hvjf8i");
            __builder.AddMarkupContent(16, "&#8249");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "p");
            __builder.AddAttribute(19, "b-52b1hvjf8i");
            __builder.AddMarkupContent(20, "Época ");
            __builder.AddContent(21, 
#nullable restore
#line 12 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Pages\ClassificacoesGerais.razor"
                           epocaPretendida-1

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, "/");
            __builder.AddContent(23, 
#nullable restore
#line 12 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Pages\ClassificacoesGerais.razor"
                                               epocaPretendida

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Pages\ClassificacoesGerais.razor"
                                                ProxEpoca

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "b-52b1hvjf8i");
            __builder.AddMarkupContent(29, "&#8250");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row");
            __builder.AddAttribute(33, "b-52b1hvjf8i");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Pages\ClassificacoesGerais.razor"
                                                PrevProva

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "b-52b1hvjf8i");
            __builder.AddMarkupContent(38, "&#8249");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "p");
            __builder.AddAttribute(41, "b-52b1hvjf8i");
            __builder.AddContent(42, "Prova ");
            __builder.AddContent(43, 
#nullable restore
#line 18 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Pages\ClassificacoesGerais.razor"
                          provaPretendida

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Pages\ClassificacoesGerais.razor"
                                                ProxProva

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "b-52b1hvjf8i");
            __builder.AddMarkupContent(49, "&#8250");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.AddMarkupContent(51, "<h1 b-52b1hvjf8i>Classificações Gerais</h1>");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "leftTable");
            __builder.AddAttribute(55, "b-52b1hvjf8i");
            __builder.AddMarkupContent(56, "<h1 b-52b1hvjf8i>Classificação Geral Pilotos</h1>");
#nullable restore
#line 28 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Pages\ClassificacoesGerais.razor"
         foreach (var piloto in pilotos)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "skillBox");
            __builder.AddAttribute(59, "b-52b1hvjf8i");
            __builder.OpenElement(60, "p");
            __builder.AddAttribute(61, "b-52b1hvjf8i");
            __builder.AddContent(62, 
#nullable restore
#line 31 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Pages\ClassificacoesGerais.razor"
                    piloto.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "p");
            __builder.AddAttribute(65, "b-52b1hvjf8i");
            __builder.AddContent(66, 
#nullable restore
#line 32 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Pages\ClassificacoesGerais.razor"
                    piloto.Pontos

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                ");
            __builder.AddMarkupContent(68, "<div class=\"skill\" b-52b1hvjf8i><div class=\"skill_level\" style=\"(\" b-52b1hvjf8i></div></div>");
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Pages\ClassificacoesGerais.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\r\n    ");
            __builder.AddMarkupContent(70, @"<div class=""rightTable"" b-52b1hvjf8i><h1 b-52b1hvjf8i>Classificação Geral Equipas</h1>
        <div class=""skillBox"" b-52b1hvjf8i><p b-52b1hvjf8i>Mercedes-Benz</p>
            <p b-52b1hvjf8i>89</p>
            <div class=""skill"" b-52b1hvjf8i><div class=""skill_level"" style=""width: 89%"" b-52b1hvjf8i></div></div></div>

        <div class=""skillBox"" b-52b1hvjf8i><p b-52b1hvjf8i>Red-Bull</p>
            <p b-52b1hvjf8i>75</p>
            <div class=""skill"" b-52b1hvjf8i><div class=""skill_level"" style=""width: 75%"" b-52b1hvjf8i></div></div></div>

        <div class=""skillBox"" b-52b1hvjf8i><p b-52b1hvjf8i>McLaren</p>
            <p b-52b1hvjf8i>40</p>
            <div class=""skill"" b-52b1hvjf8i><div class=""skill_level"" style=""width: 40%"" b-52b1hvjf8i></div></div></div></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\Carlos Preto\Desktop\3ºAno MIEI\2º Semestre\LI4\LightsOut\Pages\ClassificacoesGerais.razor"
       
    private Piloto[] pilotos;
    private int provaPretendida = 1;
    private int epocaPretendida = 2021;

    private void ProxProva()
    {
        provaPretendida++;
    }

    private void PrevProva()
    {
        if (provaPretendida >= 1)
        {
            provaPretendida--;
        }
    }

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
        pilotos = await PilotoService.GetClassificacao();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PilotoService PilotoService { get; set; }
    }
}
#pragma warning restore 1591
