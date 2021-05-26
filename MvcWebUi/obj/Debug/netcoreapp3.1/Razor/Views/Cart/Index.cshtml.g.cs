#pragma checksum "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d29de35519258339dd4db9145c815fccb7ce6bd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\_ViewImports.cshtml"
using MvcWebUi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\_ViewImports.cshtml"
using MvcWebUi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d29de35519258339dd4db9145c815fccb7ce6bd3", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50ebde56f2ec5aefb86fa3eb8b3d007d89d27fb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Cart Items</h1>\r\n");
#nullable restore
#line 5 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Cart\Index.cshtml"
 if (Model.Cart.CartLines.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"badge badge-danger\" >Ups Theres no item on your cart</h2>\r\n");
#nullable restore
#line 8 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Cart\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-responsive\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Cart\Index.cshtml"
         foreach (var cartLine in Model.Cart.CartLines)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <thead>
            <th>ID</th>
            <th>Product Name</th>
            <th>Unity Price</th>
            <th>Quantity Per Unit</th>
            <th>Category Id</th>
            <th>Quantity</th>
            </thead>
            <tbody>
                <tr>
                    <td> ");
#nullable restore
#line 25 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Cart\Index.cshtml"
                    Write(cartLine.Product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 26 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Cart\Index.cshtml"
                    Write(cartLine.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 27 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Cart\Index.cshtml"
                    Write(cartLine.Product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 28 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Cart\Index.cshtml"
                    Write(cartLine.Product.QuantityPerUnit);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 29 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Cart\Index.cshtml"
                    Write(cartLine.Product.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 30 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Cart\Index.cshtml"
                    Write(cartLine.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d29de35519258339dd4db9145c815fccb7ce6bd36912", async() => {
                WriteLiteral("Delete from Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Cart\Index.cshtml"
                                                                                                              WriteLiteral(cartLine.Product.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </td>\r\n                </tr>\r\n            </tbody>\r\n");
#nullable restore
#line 34 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Cart\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 37 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
