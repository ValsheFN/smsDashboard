#pragma checksum "C:\dev\smsDashboard\smsDashboard\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "189dd7712c90ddcbf6ba90672f145485be08f2ce"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>smsDashboard</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\dev\smsDashboard\smsDashboard\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\dev\smsDashboard\smsDashboard\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\dev\smsDashboard\smsDashboard\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\dev\smsDashboard\smsDashboard\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "nav-item px-3");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "sms");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> SMS\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(38);
            __builder.AddAttribute(39, "Roles", "Admin");
            __builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.OpenElement(42, "li");
                __builder2.AddAttribute(43, "class", "nav-item px-3");
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(45);
                __builder2.AddAttribute(46, "class", "nav-link");
                __builder2.AddAttribute(47, "href", "contact");
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(49, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Contact\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(53);
            __builder.AddAttribute(54, "Roles", "Admin");
            __builder.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.OpenElement(57, "li");
                __builder2.AddAttribute(58, "class", "nav-item px-3");
                __builder2.AddMarkupContent(59, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(60);
                __builder2.AddAttribute(61, "class", "nav-link");
                __builder2.AddAttribute(62, "href", "subaccount");
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(64, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Sub Account\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(68);
            __builder.AddAttribute(69, "Roles", "Admin");
            __builder.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(71, "\r\n            ");
                __builder2.OpenElement(72, "li");
                __builder2.AddAttribute(73, "class", "nav-item px-3");
                __builder2.AddMarkupContent(74, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(75);
                __builder2.AddAttribute(76, "class", "nav-link");
                __builder2.AddAttribute(77, "href", "topup");
                __builder2.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(79, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Top Up\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(83);
            __builder.AddAttribute(84, "Roles", "Super User");
            __builder.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(86, "\r\n            ");
                __builder2.OpenElement(87, "li");
                __builder2.AddAttribute(88, "class", "nav-item px-3");
                __builder2.AddMarkupContent(89, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(90);
                __builder2.AddAttribute(91, "class", "nav-link");
                __builder2.AddAttribute(92, "href", "granttopup");
                __builder2.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(94, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Grant Top Up\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(95, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\dev\smsDashboard\smsDashboard\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
