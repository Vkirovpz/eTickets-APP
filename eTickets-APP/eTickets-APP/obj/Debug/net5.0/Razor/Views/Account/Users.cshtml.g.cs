#pragma checksum "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Account\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b01a2a32e8ecc739d3ee5ad00f6eb3a8cc94cbc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Users), @"mvc.1.0.view", @"/Views/Account/Users.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\_ViewImports.cshtml"
using eTickets_APP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\_ViewImports.cshtml"
using eTickets_APP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\_ViewImports.cshtml"
using eTickets.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\_ViewImports.cshtml"
using eTickets.Data.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\_ViewImports.cshtml"
using eTickets_APP.ViewModels.Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\_ViewImports.cshtml"
using eTickets_APP.ViewModels.Cart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\_ViewImports.cshtml"
using eTickets_APP.ViewModels.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01a2a32e8ecc739d3ee5ad00f6eb3a8cc94cbc4", @"/Views/Account/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adbc2ff1bb82652ba730a2d6c02b265cf9469302", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Account\Users.cshtml"
  
    ViewData["Title"] = "All Users";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-6 offset-3\">\r\n        <p>\r\n            <h4>List of all users</h4>\r\n        </p>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr class=\"text-center\">\r\n                    <th>");
#nullable restore
#line 14 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 15 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 16 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Account\Users.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 24 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Account\Users.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 27 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Account\Users.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 30 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Account\Users.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Account\Users.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591