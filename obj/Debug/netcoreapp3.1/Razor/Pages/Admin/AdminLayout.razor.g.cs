#pragma checksum "C:\Users\jensh\Downloads\CrashUtahProject 2\CrashUtahProject\Pages\Admin\AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24c75d45cf11ebccf309b0f302cb29e4e2010619"
// <auto-generated/>
#pragma warning disable 1591
namespace CrashUtahProject.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\jensh\Downloads\CrashUtahProject 2\CrashUtahProject\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jensh\Downloads\CrashUtahProject 2\CrashUtahProject\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jensh\Downloads\CrashUtahProject 2\CrashUtahProject\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jensh\Downloads\CrashUtahProject 2\CrashUtahProject\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jensh\Downloads\CrashUtahProject 2\CrashUtahProject\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jensh\Downloads\CrashUtahProject 2\CrashUtahProject\Pages\Admin\_Imports.razor"
using CrashUtahProject.Models;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-info text-white p-2");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "\n            ");
            __builder.AddMarkupContent(9, "<div class=\"col-10\">\n                <span class=\"navbar-brand m-lg-2\">Crash Utah Administration</span>\n            </div>\n\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-1");
            __builder.AddMarkupContent(12, "\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "class", "btn btn-light btn-sm ");
            __builder.AddAttribute(15, "href", "/admin/create");
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(17, "Create");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n\n            ");
            __builder.AddMarkupContent(20, "<div class=\"col-1\">\n                <a class=\"btn btn-sm btn-dark\" href=\"/account/logout\">Log Out</a>\n            </div>\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "btn btn-outline-primary btn-block");
            __builder.AddAttribute(26, "href", "/admin");
            __builder.AddAttribute(27, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(28, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 21 "C:\Users\jensh\Downloads\CrashUtahProject 2\CrashUtahProject\Pages\Admin\AdminLayout.razor"
                                                                                                             NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(30, "Admin Home");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\n\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "container-fluid");
            __builder.AddMarkupContent(34, "\n    ");
            __builder.AddContent(35, 
#nullable restore
#line 24 "C:\Users\jensh\Downloads\CrashUtahProject 2\CrashUtahProject\Pages\Admin\AdminLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591