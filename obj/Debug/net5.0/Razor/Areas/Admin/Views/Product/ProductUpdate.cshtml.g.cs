#pragma checksum "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Product/ProductUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b2f1861e71e93d495e72371605c7966783712be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_ProductUpdate), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/ProductUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b2f1861e71e93d495e72371605c7966783712be", @"/Areas/Admin/Views/Product/ProductUpdate.cshtml")]
    public class Areas_Admin_Views_Product_ProductUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Product/ProductUpdate.cshtml"
  
    ViewData["Title"] = "ProductUpdate";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Ürün Güncelleme Sayfası</h1>\n\n    <form class=\"form-group\" action=\"ProductUpdate\" asp-controller=\"Product\" method=\"post\" enctype=\"multipart/form-data\">\n        ");
#nullable restore
#line 10 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Product/ProductUpdate.cshtml"
   Write(Html.Label("Ürün Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 11 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Product/ProductUpdate.cshtml"
   Write(Html.TextBoxFor(x => x.ProductId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        ");
#nullable restore
#line 13 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Product/ProductUpdate.cshtml"
   Write(Html.Label("Ürün Adı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 14 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Product/ProductUpdate.cshtml"
   Write(Html.TextBoxFor(x => x.ProductName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n        ");
#nullable restore
#line 17 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Product/ProductUpdate.cshtml"
   Write(Html.Label("Ürün Fiyatı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 18 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Product/ProductUpdate.cshtml"
   Write(Html.TextBoxFor(x => x.ProductPrice, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n        ");
#nullable restore
#line 21 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Product/ProductUpdate.cshtml"
   Write(Html.Label("Ürün Açıklaması"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 22 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Product/ProductUpdate.cshtml"
   Write(Html.TextBoxFor(x => x.ProductDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n        ");
#nullable restore
#line 25 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Product/ProductUpdate.cshtml"
   Write(Html.Label("Ürün Kategorisi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 26 "/Users/melikeozdogan/Desktop/CategoryProduct/CategoryProduct/Areas/Admin/Views/Product/ProductUpdate.cshtml"
   Write(Html.TextBoxFor(x => x.Category.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        <button type=\"submit\" class=\"btn btn-primary\">Güncelle</button>\n        </form>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
