#pragma checksum "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "add9b8fc64d32836a47a9aa7e58c5f94afeb4aa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Partials__UpdateCategoryList), @"mvc.1.0.view", @"/Views/Category/Partials/_UpdateCategoryList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add9b8fc64d32836a47a9aa7e58c5f94afeb4aa9", @"/Views/Category/Partials/_UpdateCategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfa3f35964e0e026a88eb5583a27a4f516b7857f", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Partials__UpdateCategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PointOfSale.Data.Entities.CategoryEntity>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
   ViewData["Title"] = "Category Managment"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""card mt-1 mb-1"">
    <div class=""card-body"" id=""btnItemList"" style=""overflow-x:auto"">
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
#line 17 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
                  
                    int categoryCount = 1;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 24 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
                   Write(categoryCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 26 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
                   Write(item.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
                   Write(item.PurchasePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a id=\"view_category\" name=\"CategoryId\"");
            BeginWriteAttribute("value", " value=\"", 1234, "\"", 1258, 1);
#nullable restore
#line 31 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
WriteAttributeValue("", 1242, item.CategoryId, 1242, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"View Record!\"");
            BeginWriteAttribute("class", " class=\"", 1280, "\"", 1304, 1);
#nullable restore
#line 31 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
WriteAttributeValue("", 1288, item.CategoryId, 1288, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1305, "\"", 1339, 3);
            WriteAttributeValue("", 1315, "fnView(", 1315, 7, true);
#nullable restore
#line 31 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
WriteAttributeValue("", 1322, item.CategoryId, 1322, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1338, ")", 1338, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-eye\"></i></a>\r\n                        <a id=\"edit_category\" name=\"CategoryId\"");
            BeginWriteAttribute("value", " value=\"", 1435, "\"", 1459, 1);
#nullable restore
#line 32 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
WriteAttributeValue("", 1443, item.CategoryId, 1443, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Edit Record!\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1481, "\"", 1515, 3);
            WriteAttributeValue("", 1491, "fnEdit(", 1491, 7, true);
#nullable restore
#line 32 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
WriteAttributeValue("", 1498, item.CategoryId, 1498, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1514, ")", 1514, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></a>\r\n                        <a id=\"delete_category\" name=\"CategoryId\"");
            BeginWriteAttribute("value", " value=\"", 1614, "\"", 1638, 1);
#nullable restore
#line 33 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
WriteAttributeValue("", 1622, item.CategoryId, 1622, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Delete Record!\"");
            BeginWriteAttribute("class", " class=\"", 1662, "\"", 1693, 2);
            WriteAttributeValue("", 1670, "delete_", 1670, 7, true);
#nullable restore
#line 33 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
WriteAttributeValue("", 1677, item.CategoryId, 1677, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1694, "\"", 1730, 3);
            WriteAttributeValue("", 1704, "fnDelete(", 1704, 9, true);
#nullable restore
#line 33 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
WriteAttributeValue("", 1713, item.CategoryId, 1713, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1729, ")", 1729, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i></a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 36 "D:\InvozealTechnologies\New POS\PointOfSale.Web\Views\Category\Partials\_UpdateCategoryList.cshtml"
                    categoryCount++;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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