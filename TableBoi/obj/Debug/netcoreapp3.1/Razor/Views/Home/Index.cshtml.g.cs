#pragma checksum "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b018095b5b9ddaf60a5a07e5c4a857f8e2529c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\_ViewImports.cshtml"
using TableBoi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\_ViewImports.cshtml"
using TableBoi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b018095b5b9ddaf60a5a07e5c4a857f8e2529c7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3014bec34504ec91b07b82ac6268b6ef9d2a63d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TableBoi.Models.TaskModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AddForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("EditForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>???????????? ??????????</h2>\r\n\r\n");
            WriteLiteral(@"<div id=""addElement"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">???????????????? ?????????? ????????????</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b018095b5b9ddaf60a5a07e5c4a857f8e2529c74494", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 17 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
                   Write(Html.LabelFor(m => m.TaskName, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 18 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.TaskName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <span class=\"text-danger\"></span>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 22 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
                   Write(Html.LabelFor(m => m.TaskDescription, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 23 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.TaskDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <span class=\"text-danger\"></span>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div id=""spinner"" class=""spinner-border"" role=""status"" style=""display: none;"">
                    <span class=""sr-only"">????????????????????...</span>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">??????????????</button>
                <button id=""addTask"" type=""button"" class=""btn btn-primary"">???????????????? ????????????</button>
            </div>
            <br />
        </div>
    </div>
</div>

");
            WriteLiteral(@"<div id=""editElement"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">???????????????? ????????????</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b018095b5b9ddaf60a5a07e5c4a857f8e2529c78478", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 52 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
               Write(Html.HiddenFor(m => m.Id, new { @id = "Id" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 54 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
                   Write(Html.LabelFor(m => m.TaskName, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 55 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.TaskName, new { @class = "form-control", @id = "taskName" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <span class=\"text-danger\"></span>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 59 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
                   Write(Html.LabelFor(m => m.TaskDescription, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 60 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.TaskDescription, new { @class = "form-control", @id = "taskDescription" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <span class=\"text-danger\"></span>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div id=""spinner"" class=""spinner-border"" role=""status"" style=""display: none;"">
                    <span class=""sr-only"">???????????????????? ??????????????????...</span>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">??????????????</button>
                <button id=""editTask"" type=""button"" class=""btn btn-primary"">??????????????????</button>
            </div>
        </div>
    </div>
</div>

");
            WriteLiteral(@"<div id=""deleteElement"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">?????????????? ????????????</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
#nullable restore
#line 87 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
           Write(Html.HiddenFor(m => m.Id, new { @id = "taskId" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <h5>???? ?????????????????????????? ???????????? ?????????????? ?????????????</h5>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">??????????????</button>
                <button id=""deleteTask"" type=""button"" class=""btn btn-danger"">??????????????</button>
            </div>
            <div id=""spinner"" class=""spinner-border"" role=""status"" style=""display: none;"">
                <span class=""sr-only"">????????????????...</span>
            </div>
        </div>
    </div>
</div>

");
#nullable restore
#line 101 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
 if (ViewBag.Tasks != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 107 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 110 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TaskName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 113 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TaskDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 116 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 121 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
             foreach (var item in ViewBag.Tasks)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 125 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 128 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
                    Write(item.TaskName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 131 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
                    Write(item.TaskDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 134 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
                    Write(item.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 137 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
                   Write(Html.ActionLink("??????????????????????????", "", new { /* id=item.PrimaryKey */ }, new { @class = "btn btn-success", @data_toggle = "modal", @data_target = "#editElement", onclick = "editTask(" + item.Id + ");" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 138 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
                   Write(Html.ActionLink("??????????????", "", new { /* id=item.Primar yKey */ }, new { @class = "btn btn-danger", @data_toggle = "modal", @data_target = "#deleteElement", onclick = "confirmDelete(" + item.Id + ");" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 141 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n    <button class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"#addElement\">???????????????? ????????????</button>\r\n");
#nullable restore
#line 146 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<button class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"#addElement\">?????????????? ???????????? ????????????</button>\r\n");
#nullable restore
#line 150 "C:\Users\Saturn\source\repos\TableBoi\TableBoi\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TableBoi.Models.TaskModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
