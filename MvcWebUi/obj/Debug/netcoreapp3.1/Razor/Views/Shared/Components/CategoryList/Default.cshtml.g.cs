#pragma checksum "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "686c68b322788da17942a7f1ca7ea5fab71277bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686c68b322788da17942a7f1ca7ea5fab71277bd", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50ebde56f2ec5aefb86fa3eb8b3d007d89d27fb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryListModelView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Index</h1>\r\n<div class=\"list-group\">\r\n");
#nullable restore
#line 6 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Shared\Components\CategoryList\Default.cshtml"
        var addition = "";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Shared\Components\CategoryList\Default.cshtml"
     if (Model.CurrentCategory == 0)
    {
        addition = "active";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n    <a href=\"/product/index\"");
            BeginWriteAttribute("class", " class=\"", 220, "\"", 253, 2);
            WriteAttributeValue("", 228, "list-group-item", 228, 15, true);
#nullable restore
#line 12 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue(" ", 243, addition, 244, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">All</a>\r\n");
#nullable restore
#line 13 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Shared\Components\CategoryList\Default.cshtml"
     foreach (var category in Model.Categories)
    {
        var css = "list-group-item";
        if (category.CategoryID == Model.CurrentCategory)
        {
            css += " active";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 480, "\"", 531, 2);
            WriteAttributeValue("", 487, "/product/index?category=", 487, 24, true);
#nullable restore
#line 20 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 511, category.CategoryID, 511, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 532, "\"", 544, 1);
#nullable restore
#line 20 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 540, css, 540, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                       Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 21 "C:\Users\ACER\source\repos\NortwindLevelTwoReal\MvcWebUi\Views\Shared\Components\CategoryList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryListModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591
