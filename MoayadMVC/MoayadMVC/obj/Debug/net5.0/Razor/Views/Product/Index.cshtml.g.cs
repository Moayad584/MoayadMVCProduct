#pragma checksum "C:\Users\E480\Desktop\Moayad MVC git\MoayadMVC\MoayadMVC\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17401d5b79eea0a5460725a6964150658cec4249"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\E480\Desktop\Moayad MVC git\MoayadMVC\MoayadMVC\Views\_ViewImports.cshtml"
using MoayadMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\E480\Desktop\Moayad MVC git\MoayadMVC\MoayadMVC\Views\_ViewImports.cshtml"
using MoayadMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17401d5b79eea0a5460725a6964150658cec4249", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dd565a95973f315f4dd39c84cdb195eecce7ebb", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Data.DataTable>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\E480\Desktop\Moayad MVC git\MoayadMVC\MoayadMVC\Views\Product\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered table-table-striped\">\r\n    <tr>\r\n        <th>Product Name </th>\r\n        <th>Price</th>\r\n        <th>Quantity</th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\E480\Desktop\Moayad MVC git\MoayadMVC\MoayadMVC\Views\Product\Index.cshtml"
     for (int i = 0; i < Model.Rows.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 16 "C:\Users\E480\Desktop\Moayad MVC git\MoayadMVC\MoayadMVC\Views\Product\Index.cshtml"
           Write(Model.Rows[i][1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 17 "C:\Users\E480\Desktop\Moayad MVC git\MoayadMVC\MoayadMVC\Views\Product\Index.cshtml"
            Write(Model.Rows[i][2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 18 "C:\Users\E480\Desktop\Moayad MVC git\MoayadMVC\MoayadMVC\Views\Product\Index.cshtml"
             Write(Model.Rows[i][3]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>\r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 480, "\"", 546, 1);
#nullable restore
#line 20 "C:\Users\E480\Desktop\Moayad MVC git\MoayadMVC\MoayadMVC\Views\Product\Index.cshtml"
WriteAttributeValue("", 487, Url.Action("Edit", "Product", new {@id=@Model.Rows[i][0]}), 487, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n              </td>\r\n        </tr>\n");
#nullable restore
#line 23 "C:\Users\E480\Desktop\Moayad MVC git\MoayadMVC\MoayadMVC\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 616, "\"", 654, 1);
#nullable restore
#line 27 "C:\Users\E480\Desktop\Moayad MVC git\MoayadMVC\MoayadMVC\Views\Product\Index.cshtml"
WriteAttributeValue("", 623, Url.Action("Create","Product"), 623, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add Product</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Data.DataTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
