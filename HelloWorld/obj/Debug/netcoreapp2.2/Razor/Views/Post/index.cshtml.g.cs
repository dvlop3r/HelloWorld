#pragma checksum "c:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Post\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "465b44921a10d9819d64d09aad1f1d92a855f18c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_index), @"mvc.1.0.view", @"/Views/Post/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/index.cshtml", typeof(AspNetCore.Views_Post_index))]
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
#line 2 "c:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Post\index.cshtml"
using HelloWorld.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"465b44921a10d9819d64d09aad1f1d92a855f18c", @"/Views/Post/index.cshtml")]
    public class Views_Post_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
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
        private global::AspNetCore.Views_Post_index.__Generated__PostedDataViewComponentTagHelper __PostedDataViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 58, true);
            WriteLiteral("\r\n\r\n\r\n<h3>this is index action from Post controller</h3>\r\n");
            EndContext();
            BeginContext(131, 59, false);
#line 8 "c:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Post\index.cshtml"
Write(Html.ActionLink("Back to Home controller", "index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(190, 62, true);
            WriteLiteral("<br /><br />\r\n\r\n<h4>Data from View component controller</h4>\r\n");
            EndContext();
            BeginContext(252, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:posted-data", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "465b44921a10d9819d64d09aad1f1d92a855f18c3404", async() => {
            }
            );
            __PostedDataViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Post_index.__Generated__PostedDataViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__PostedDataViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(270, 161, true);
            WriteLiteral("\r\n<br />\r\n\r\n<h4>Data from database</h4>\r\n<table>\r\n    <tr>\r\n        <th>Post ID</th>\r\n        <th>Post content</th>\r\n        <th>Post date time</th>\r\n    </tr>\r\n");
            EndContext();
#line 21 "c:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Post\index.cshtml"
     foreach (var post in Model.Posts)
    {

#line default
#line hidden
            BeginContext(478, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(509, 7, false);
#line 24 "c:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Post\index.cshtml"
           Write(post.id);

#line default
#line hidden
            EndContext();
            BeginContext(516, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(540, 9, false);
#line 25 "c:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Post\index.cshtml"
           Write(post.post);

#line default
#line hidden
            EndContext();
            BeginContext(549, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(573, 19, false);
#line 26 "c:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Post\index.cshtml"
           Write(post.postedDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(592, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 28 "c:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Post\index.cshtml"
    }

#line default
#line hidden
            BeginContext(621, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:posted-data")]
        public class __Generated__PostedDataViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__PostedDataViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("PostedData", new {  });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
