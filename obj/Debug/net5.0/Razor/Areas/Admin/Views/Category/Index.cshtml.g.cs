#pragma checksum "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c53be9709993a763362de213769141c64d140ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c53be9709993a763362de213769141c64d140ea", @"/Areas/Admin/Views/Category/Index.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!--  LİST-UPDATE-DELETE   -->

<table class=""table"">
    <thead class=""thead-light"">
        <tr>
            <th scope=""col"">Kategori Adı</th>
            <th scope=""col"">Kategori Açıklaması</th>

            <th scope=""col"">Güncelle </th>
            <th scope=""col"">Sil </th>

        </tr>
    </thead>
</table>

<table class=""table table-striped table-hover"">
");
#nullable restore
#line 26 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\n            <tr>\n                <td>");
#nullable restore
#line 30 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/Index.cshtml"
               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                <td>");
#nullable restore
#line 31 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/Index.cshtml"
               Write(item.CategoryDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                <td> <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 721, "\"", 775, 2);
            WriteAttributeValue("", 728, "/Admin/Category/CategoryUpdate/", 728, 31, true);
#nullable restore
#line 32 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/Index.cshtml"
WriteAttributeValue("", 759, item.CategoryId, 759, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Güncelle</a></td>\n                <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 840, "\"", 894, 2);
            WriteAttributeValue("", 847, "/Admin/Category/CategoryDelete/", 847, 31, true);
#nullable restore
#line 33 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/Index.cshtml"
WriteAttributeValue("", 878, item.CategoryId, 878, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil </a></td>\n            </tr>\n        </tbody>\n");
#nullable restore
#line 36 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
