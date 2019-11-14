#pragma checksum "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/Pages/Planets.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e70d6ff54ce8530cfebaa97196e8f412284706f8"
// <auto-generated/>
#pragma warning disable 1591
namespace blazor_web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/_Imports.razor"
using blazor_web;

#line default
#line hidden
#line 7 "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/_Imports.razor"
using blazor_web.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/planets")]
    public class Planets : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\n");
#line 6 "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/Pages/Planets.razor"
     if(request == null)
    {

#line default
#line hidden
            __builder.AddContent(2, "        ");
            __builder.AddMarkupContent(3, "<div>Loading...</div>\n");
#line 9 "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/Pages/Planets.razor"
    }
    else
    {

#line default
#line hidden
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\n");
#line 13 "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/Pages/Planets.razor"
             foreach (var planet in request.Results)
            {

#line default
#line hidden
            __builder.AddContent(7, "                ");
            __builder.OpenElement(8, "div");
            __builder.AddContent(9, 
#line 15 "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/Pages/Planets.razor"
                      planet.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n");
#line 16 "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/Pages/Planets.razor"
            }

#line default
#line hidden
            __builder.AddContent(11, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n");
#line 18 "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/Pages/Planets.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 21 "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/Pages/Planets.razor"
       
    PlanetRequest request = null;

    protected override async Task OnInitializedAsync()
    {
        request = await Http.GetJsonAsync<PlanetRequest>("https://swapi.co.api/planets");
    }

    public class PlanetRequest 
    {
        public Planet[] Results { get; set; }
    }

    public class Planet
    {
        public string Name { get; set; }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
