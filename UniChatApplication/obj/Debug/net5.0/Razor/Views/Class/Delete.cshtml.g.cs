#pragma checksum "H:\GitHub\UniChat\UniChatApplication\Views\Class\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48861aa171edee9c6b634508210901eaf6973dcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Class_Delete), @"mvc.1.0.view", @"/Views/Class/Delete.cshtml")]
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
#line 1 "H:\GitHub\UniChat\UniChatApplication\Views\_ViewImports.cshtml"
using UniChatApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\GitHub\UniChat\UniChatApplication\Views\_ViewImports.cshtml"
using UniChatApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48861aa171edee9c6b634508210901eaf6973dcf", @"/Views/Class/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"117675200237a5f49f8acab2be1560d50c609162", @"/Views/_ViewImports.cshtml")]
    public class Views_Class_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniChatApplication.Models.Class>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "H:\GitHub\UniChat\UniChatApplication\Views\Class\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>

    body {
        font-family: 'Times New Roman', Times, serif;
        padding: 1rem;
    }

    h1 {
        font-weight: 600;
    }

    .content {
        display: flex;
        gap: 1rem;
    }

    .left-content, .right-content {
        flex: 1;
        display: flex;
        flex-direction: column;
    }

</style>

<div class=""container"">

    <div class=""title"">
        <h1 class=""text-center"">Class Management</h1>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48861aa171edee9c6b634508210901eaf6973dcf5294", async() => {
                WriteLiteral("Back to Index");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <hr>\r\n    <h3>Are you sure you want to delete this?</h3>\r\n    <hr>\r\n    <div class=\"content\">\r\n        <div class=\"left-content\">\r\n            <h4 class=\"text-primary\">");
#nullable restore
#line 41 "H:\GitHub\UniChat\UniChatApplication\Views\Class\Delete.cshtml"
                                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
            <hr>
            <div class=""boxchatlist"">
                <h4>Roomchat</h4>
                <ol style=""margin-left: 3rem;"">
                    <li>SubjectName
                        <ul style=""margin-left: 3rem;"">
                            <li>GroupName</li>
                            <li>GroupName</li>
                            <li>GroupName</li>
                        </ul>
                    </li>
                    <li>SubjectName
                        <ul style=""margin-left: 3rem;"">
                            <li>GroupName</li>
                            <li>GroupName</li>
                            <li>GroupName</li>
                        </ul>
                    </li>
                    <li>SubjectName
                        <ul style=""margin-left: 3rem;"">
                            <li>GroupName</li>
                            <li>GroupName</li>
                            <li>GroupName</li>
                        </ul>
               ");
            WriteLiteral(@"     </li>
                </ol>
            </div>

        </div>
        <div class=""right-content"">
            <h4 class=""text-center text-info"">List of students of this class</h4>
            <hr>
            <table class=""table table-bordered"">
                <thead>
                    <th>Avatar</th>
                    <th>StudentCode</th>
                    <th>FullName</th>
                </thead>
                <tbody>
");
#nullable restore
#line 81 "H:\GitHub\UniChat\UniChatApplication\Views\Class\Delete.cshtml"
                     foreach (StudentProfile item in Model.StudentProfiles)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 2504, "\"", 2510, 0);
            EndWriteAttribute();
            WriteLiteral(" alt=\"avatar\">\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 88 "H:\GitHub\UniChat\UniChatApplication\Views\Class\Delete.cshtml"
                           Write(item.StudentCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 91 "H:\GitHub\UniChat\UniChatApplication\Views\Class\Delete.cshtml"
                           Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 94 "H:\GitHub\UniChat\UniChatApplication\Views\Class\Delete.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48861aa171edee9c6b634508210901eaf6973dcf10064", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 3015, "\"", 3032, 1);
#nullable restore
#line 101 "H:\GitHub\UniChat\UniChatApplication\Views\Class\Delete.cshtml"
WriteAttributeValue("", 3023, Model.Id, 3023, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniChatApplication.Models.Class> Html { get; private set; }
    }
}
#pragma warning restore 1591
