#pragma checksum "/Users/shankarvasudevan/Repo/myprojects/MyFirstBlazor/MyFirstBlazorApp/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66793201f70738302fd555d53cb4c21a42654ad7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyFirstBlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/shankarvasudevan/Repo/myprojects/MyFirstBlazor/MyFirstBlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/Users/shankarvasudevan/Repo/myprojects/MyFirstBlazor/MyFirstBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/Users/shankarvasudevan/Repo/myprojects/MyFirstBlazor/MyFirstBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "/Users/shankarvasudevan/Repo/myprojects/MyFirstBlazor/MyFirstBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "/Users/shankarvasudevan/Repo/myprojects/MyFirstBlazor/MyFirstBlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "/Users/shankarvasudevan/Repo/myprojects/MyFirstBlazor/MyFirstBlazorApp/_Imports.razor"
using MyFirstBlazorApp;

#line default
#line hidden
#line 7 "/Users/shankarvasudevan/Repo/myprojects/MyFirstBlazor/MyFirstBlazorApp/_Imports.razor"
using MyFirstBlazorApp.Shared;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 28 "/Users/shankarvasudevan/Repo/myprojects/MyFirstBlazor/MyFirstBlazorApp/Shared/NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
