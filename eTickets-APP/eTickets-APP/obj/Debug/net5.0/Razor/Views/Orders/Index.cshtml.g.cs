#pragma checksum "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9270e6adec7631b88bef8f35c89dd62a4f567767"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9270e6adec7631b88bef8f35c89dd62a4f567767", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00c9778625c8a15ab77e4629704b03f27c93896a", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "All orders";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-8 offset-2"">
        <p>
            <h4>List of all your orders</h4>
        </p>

        <table class=""table"">
            <thead>
                <tr>
                    <th>Order ID</th>
                    <th>Items</th>
                    <th>Total</th>
");
            WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Orders\Index.cshtml"
                 foreach (var order in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">");
#nullable restore
#line 29 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Orders\Index.cshtml"
                                            Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"align-middle\">\r\n                            <ul style=\"list-style-type:none\">\r\n");
#nullable restore
#line 32 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Orders\Index.cshtml"
                                 foreach (var item in order.OrderItems)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\r\n                                        <div class=\"alert alert-info\" role=\"alert\">\r\n                                            <span class=\"badge bg-success\">");
#nullable restore
#line 36 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Orders\Index.cshtml"
                                                                      Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> [");
#nullable restore
#line 36 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Orders\Index.cshtml"
                                                                                           Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("] - ");
#nullable restore
#line 36 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Orders\Index.cshtml"
                                                                                                                        Write(item.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </li>\r\n");
#nullable restore
#line 39 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Orders\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 43 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Orders\Index.cshtml"
                       Write(order.OrderItems.Select(m => m.Movie.Price * m.Amount).Sum().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 45 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Orders\Index.cshtml"
                         if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"align-middle\"> - </td>\r\n");
#nullable restore
#line 48 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Orders\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 50 "C:\Users\Valentin\Desktop\c#\eTickets-APP\eTickets-APP\eTickets-APP\Views\Orders\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591