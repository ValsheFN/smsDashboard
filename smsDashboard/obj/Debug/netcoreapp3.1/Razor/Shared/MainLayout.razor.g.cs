#pragma checksum "C:\dev\smsDashboard\smsDashboard\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da2568bd6639c8d310c2f50cdaa3fbbd27a99a9b"
// <auto-generated/>
#pragma warning disable 1591
namespace smsDashboard.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\dev\smsDashboard\smsDashboard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\smsDashboard\smsDashboard\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dev\smsDashboard\smsDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\dev\smsDashboard\smsDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\dev\smsDashboard\smsDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\dev\smsDashboard\smsDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\dev\smsDashboard\smsDashboard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\dev\smsDashboard\smsDashboard\_Imports.razor"
using smsDashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\dev\smsDashboard\smsDashboard\_Imports.razor"
using smsDashboard.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<smsDashboard.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "top-row px-4 auth");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenComponent<smsDashboard.Shared.LoginDisplay>(12);
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.AddMarkupContent(14, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">About</a>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "content px-4");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddContent(19, 
#nullable restore
#line 14 "C:\dev\smsDashboard\smsDashboard\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
