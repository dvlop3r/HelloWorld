#pragma checksum "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7330ccc6ddb7e92e6dbbc18498896e7f913ac42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/index.cshtml", typeof(AspNetCore.Views_Home_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7330ccc6ddb7e92e6dbbc18498896e7f913ac42", @"/Views/Home/index.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelloWorld.Models.Employees[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
#line 4 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
 if (ViewData["message"] != null)
{

#line default
#line hidden
            BeginContext(86, 23, true);
            WriteLiteral("    <p class=\"message\">");
            EndContext();
            BeginContext(110, 19, false);
#line 6 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
                  Write(ViewData["message"]);

#line default
#line hidden
            EndContext();
            BeginContext(129, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 7 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
}

#line default
#line hidden
#line 8 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
 if (TempData["message"] != null)
{

#line default
#line hidden
            BeginContext(176, 23, true);
            WriteLiteral("    <p class=\"message\">");
            EndContext();
            BeginContext(200, 19, false);
#line 10 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
                  Write(TempData["message"]);

#line default
#line hidden
            EndContext();
            BeginContext(219, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 11 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
}

#line default
#line hidden
            BeginContext(228, 41, true);
            WriteLiteral("<h4>List of employees registered</h4>\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 269, "\"", 297, 1);
#line 13 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
WriteAttributeValue("", 276, Url.Action("create"), 276, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(298, 313, true);
            WriteLiteral(@" class=""action"">Create new</a><br /><br />
<table class=""table-index"">
    <tr>
        <th>Employee ID</th>
        <th>Full name</th>
        <th>Position Title</th>
        <th>Department</th>
        <th>Email</th>
        <th>Grade</th>
        <th>Gender</th>
        <th>Actions</th>
    </tr>
");
            EndContext();
#line 25 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
     foreach (var employee in Model)
    {

#line default
#line hidden
            BeginContext(656, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(687, 11, false);
#line 28 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
           Write(employee.id);

#line default
#line hidden
            EndContext();
            BeginContext(698, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(722, 13, false);
#line 29 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
           Write(employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(735, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(759, 17, false);
#line 30 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
           Write(employee.Position);

#line default
#line hidden
            EndContext();
            BeginContext(776, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(800, 19, false);
#line 31 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
           Write(employee.Department);

#line default
#line hidden
            EndContext();
            BeginContext(819, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(843, 14, false);
#line 32 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
           Write(employee.Email);

#line default
#line hidden
            EndContext();
            BeginContext(857, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(881, 14, false);
#line 33 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
           Write(employee.Grade);

#line default
#line hidden
            EndContext();
            BeginContext(895, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(919, 15, false);
#line 34 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
           Write(employee.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(934, 43, true);
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 977, "\"", 1034, 1);
#line 36 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
WriteAttributeValue("", 984, Url.Action("detail","home",new {id=employee.id }), 984, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1035, 13, true);
            WriteLiteral(">Detail</a><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1048, "\"", 1103, 1);
#line 36 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
WriteAttributeValue("", 1055, Url.Action("edit","home",new { id=employee.id}), 1055, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1104, 54, true);
            WriteLiteral(">Edit</a><a onclick=\"return confirm(\'Are you sure?\');\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1158, "\"", 1215, 1);
#line 36 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
WriteAttributeValue("", 1165, Url.Action("delete","home",new {id=employee.id }), 1165, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1216, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 39 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
    }

#line default
#line hidden
            BeginContext(1270, 34, true);
            WriteLiteral("</table>\r\n<div class=\"ajaxCall\">\r\n");
            EndContext();
#line 42 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
     for (int pageNumber = 0; pageNumber < ViewBag.pageCount; pageNumber++)
    {

#line default
#line hidden
            BeginContext(1388, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1398, "\"", 1414, 1);
#line 44 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
WriteAttributeValue("", 1403, pageNumber, 1403, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1415, "\"", 1449, 1);
#line 44 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
WriteAttributeValue("", 1422, Url.Action("index","home"), 1422, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1450, 37, true);
            WriteLiteral(" onclick=\"return sendRequest(this);\">");
            EndContext();
            BeginContext(1489, 14, false);
#line 44 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
                                                                                               Write(pageNumber + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1504, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 45 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\index.cshtml"
    }

#line default
#line hidden
            BeginContext(1517, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelloWorld.Models.Employees[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
