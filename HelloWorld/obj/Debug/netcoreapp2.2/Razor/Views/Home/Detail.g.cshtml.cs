#pragma checksum "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "360cff7573e7f4e0abc53159808741cc7e4dd8d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"360cff7573e7f4e0abc53159808741cc7e4dd8d0", @"/Views/Home/Detail.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelloWorld.Models.Employees>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\Detail.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(70, 36, true);
            WriteLiteral("\r\n<br />\r\n<h4>Detail of employee ID ");
            EndContext();
            BeginContext(107, 8, false);
#line 8 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\Detail.cshtml"
                     Write(Model.id);

#line default
#line hidden
            EndContext();
            BeginContext(115, 24, true);
            WriteLiteral("</h4>\r\n<a class=\"action\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 139, "\"", 166, 1);
#line 9 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\Detail.cshtml"
WriteAttributeValue("", 146, Url.Action("index"), 146, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(167, 263, true);
            WriteLiteral(@">Back to index</a>
<br /><br />
<table class=""table-index"">
    <tr>
        <th>Full name</th>
        <th>Position</th>
        <th>Department</th>
        <th>Email</th>
        <th>Grade</th>
        <th>Gender</th>
    </tr>
    <tr>
        <td>");
            EndContext();
            BeginContext(431, 10, false);
#line 21 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\Detail.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(441, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(461, 14, false);
#line 22 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\Detail.cshtml"
       Write(Model.Position);

#line default
#line hidden
            EndContext();
            BeginContext(475, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(495, 16, false);
#line 23 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\Detail.cshtml"
       Write(Model.Department);

#line default
#line hidden
            EndContext();
            BeginContext(511, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(531, 11, false);
#line 24 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\Detail.cshtml"
       Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(542, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(562, 11, false);
#line 25 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\Detail.cshtml"
       Write(Model.Grade);

#line default
#line hidden
            EndContext();
            BeginContext(573, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(593, 12, false);
#line 26 "C:\Users\Administrator.pc-PC\Documents\git\HelloWorld\HelloWorld\Views\Home\Detail.cshtml"
       Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(605, 28, true);
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelloWorld.Models.Employees> Html { get; private set; }
    }
}
#pragma warning restore 1591
