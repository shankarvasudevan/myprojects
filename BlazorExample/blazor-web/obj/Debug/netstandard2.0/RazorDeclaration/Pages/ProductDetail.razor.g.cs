#pragma checksum "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/Pages/ProductDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "815c97d53d774508dd8fcd84e42eea94fbaeeb42"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/productdetail")]
    public class ProductDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 9 "/Users/shankarvasudevan/Repo/myprojects/BlazorExample/blazor-web/Pages/ProductDetail.razor"
       
    [Parameter]
    public string Title { get; set; } = "Product detail";

    [Parameter]
    public string Description { get; set; } = "Description";

    [Parameter]
    public EventCallback<string> OnClick { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
