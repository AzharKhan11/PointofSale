#pragma checksum "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4be3d9039cc02d812eb14c672ae79e68e212e4f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Partials__CategoryList), @"mvc.1.0.view", @"/Views/Category/Partials/_CategoryList.cshtml")]
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
#line 1 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\_ViewImports.cshtml"
using PointOfSale.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\_ViewImports.cshtml"
using PointOfSale.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be3d9039cc02d812eb14c672ae79e68e212e4f5", @"/Views/Category/Partials/_CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfa3f35964e0e026a88eb5583a27a4f516b7857f", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Partials__CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PointOfSale.Data.Entities.CategoryEntity>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
   ViewData["Title"] = "Category Managment"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""card mt-1 mb-1"">
    <div class=""card-body"" id=""btnCategoryList"" style=""overflow-x:auto"">
        <table id=""dataTable"" class=""table table-bordered table-striped"">
            <thead style=""text-align:center"">
                <tr>
                    <th>Sr:No</th>
                    <th>Category Name</th>
                    <th>Sale Price</th>
                    <th>Purchase Price</th>
                    <th>Description</th>
                    <th style=""max-width:20px;"">Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 17 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
                  
                    int categoryCount = 1;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 24 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
                       Write(categoryCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 26 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
                       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
                       Write(item.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
                       Write(item.PurchasePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a id=\"view_category\" name=\"CategoryId\"");
            BeginWriteAttribute("value", " value=\"", 1278, "\"", 1302, 1);
#nullable restore
#line 31 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
WriteAttributeValue("", 1286, item.CategoryId, 1286, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"View Record!\"");
            BeginWriteAttribute("class", " class=\"", 1324, "\"", 1348, 1);
#nullable restore
#line 31 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
WriteAttributeValue("", 1332, item.CategoryId, 1332, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1349, "\"", 1382, 2);
            WriteAttributeValue("", 1359, "fnView(", 1359, 7, true);
#nullable restore
#line 31 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
WriteAttributeValue("", 1366, item.CategoryId, 1366, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-eye\"></i></a>\r\n                            <a id=\"edit_category\" name=\"CategoryId\"");
            BeginWriteAttribute("value", " value=\"", 1482, "\"", 1506, 1);
#nullable restore
#line 32 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
WriteAttributeValue("", 1490, item.CategoryId, 1490, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Edit Record!\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1528, "\"", 1554, 1);
#nullable restore
#line 32 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
WriteAttributeValue("", 1538, item.CategoryId, 1538, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></a>\r\n                            <a id=\"delete_category\" name=\"CategoryId\"");
            BeginWriteAttribute("value", " value=\"", 1657, "\"", 1681, 1);
#nullable restore
#line 33 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
WriteAttributeValue("", 1665, item.CategoryId, 1665, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Delete Record!\"");
            BeginWriteAttribute("class", " class=\"", 1705, "\"", 1736, 2);
            WriteAttributeValue("", 1713, "delete_", 1713, 7, true);
#nullable restore
#line 33 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
WriteAttributeValue("", 1720, item.CategoryId, 1720, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1737, "\"", 1763, 1);
#nullable restore
#line 33 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
WriteAttributeValue("", 1747, item.CategoryId, 1747, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i></a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 36 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_CategoryList.cshtml"
                    categoryCount++;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

<script type=""text/javascript"">
    function ViewItemDetail(id) {
        $(""#ViewItemDetail"").Show();
        $(""#btnCategoryList"").hide();
        $.ajax({
            type: 'Get',
            data: { id: id },
            url: '/Category/GetCategoryDetail',
            success: function (data) {
                if (typeof data !== ""undefined"" && data !== """" && data !== null) {
                    $('#CategoryDetailForm').html(data);
                    $('#CategoryDetailForm').show();
                }
                else {
                    $.notify(""Something is wrong."", ""danger"");
                }
            }
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PointOfSale.Data.Entities.CategoryEntity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
