#pragma checksum "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/CategoryUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b926aebb5e9f95c1c267d743a5cedf8efbe38b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_CategoryUpdate), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/CategoryUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b926aebb5e9f95c1c267d743a5cedf8efbe38b3", @"/Areas/Admin/Views/Category/CategoryUpdate.cshtml")]
    public class Areas_Admin_Views_Category_CategoryUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/CategoryUpdate.cshtml"
  
    ViewData["Title"] = "CategoryUpdate";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n<h1>Kategori Güncelleme Sayfası</h1>\n<br />\n<form class=\"form-group\" action=\"CategoryUpdate\" asp-controller=\"Category\" method=\"post\" enctype=\"multipart/form-data\">\n\n        ");
#nullable restore
#line 11 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/CategoryUpdate.cshtml"
   Write(Html.Label("Kategori Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 12 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/CategoryUpdate.cshtml"
   Write(Html.TextBoxFor(x => x.CategoryId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        ");
#nullable restore
#line 14 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/CategoryUpdate.cshtml"
   Write(Html.Label("Kategori Adı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 15 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/CategoryUpdate.cshtml"
   Write(Html.TextBoxFor(x => x.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        ");
#nullable restore
#line 17 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/CategoryUpdate.cshtml"
   Write(Html.Label("Kategori Açıklaması"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 18 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Category/CategoryUpdate.cshtml"
   Write(Html.TextBoxFor(x => x.CategoryDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            WriteLiteral("        <br />\n        <button type=\"submit\" class=\"btn btn-primary\">Güncelle</button>\n    </form>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
