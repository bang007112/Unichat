#pragma checksum "C:\Users\PhucHT\Desktop\UniChatWeb\UniChatApplication\Views\UserProfile\UpdatePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6171593dfb2bc492d1a4dc9518e14b4e45cdabfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserProfile_UpdatePassword), @"mvc.1.0.view", @"/Views/UserProfile/UpdatePassword.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\PhucHT\Desktop\UniChatWeb\UniChatApplication\Views\_ViewImports.cshtml"
using UniChatApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PhucHT\Desktop\UniChatWeb\UniChatApplication\Views\_ViewImports.cshtml"
using UniChatApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PhucHT\Desktop\UniChatWeb\UniChatApplication\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6171593dfb2bc492d1a4dc9518e14b4e45cdabfb", @"/Views/UserProfile/UpdatePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f8882e37c27f053e7649db748dbd056d6e451ad", @"/Views/_ViewImports.cshtml")]
    public class Views_UserProfile_UpdatePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Account>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button-3 text-white text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdatePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\PhucHT\Desktop\UniChatWeb\UniChatApplication\Views\UserProfile\UpdatePassword.cshtml"
  
    ViewData["Title"] = "UpdatePassword";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    * {
        margin: 0;
        padding: 0;
        box-sizing: border-box;
        font-family: monospace, sans-serif;
    }

    .form-container {
        display: flex;
        justify-content: center;
        align-items: center;
        height: 80vh;
        width: 100vw;
    }

    form {
        box-shadow: 0 0 5px 1px blue;
        padding: 2rem;
    }


</style>

");
            WriteLiteral("\n<div class=\"form-container\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6171593dfb2bc492d1a4dc9518e14b4e45cdabfb5552", async() => {
                WriteLiteral("\n        <h1 class=\"text-center text-primary\">Update Password</h1>\n        <div class=\"form-group\">\n");
#nullable restore
#line 36 "C:\Users\PhucHT\Desktop\UniChatWeb\UniChatApplication\Views\UserProfile\UpdatePassword.cshtml"
             if(TempData["UpdatePasswordStatus"] != null) {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\PhucHT\Desktop\UniChatWeb\UniChatApplication\Views\UserProfile\UpdatePassword.cshtml"
                 if ((bool) TempData["UpdatePasswordStatus"]){

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"alert alert-success alert-dismissible\">\n                        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\n                        <strong>");
#nullable restore
#line 40 "C:\Users\PhucHT\Desktop\UniChatWeb\UniChatApplication\Views\UserProfile\UpdatePassword.cshtml"
                           Write(TempData["UpdatePasswordMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\n                    </div>\n");
#nullable restore
#line 42 "C:\Users\PhucHT\Desktop\UniChatWeb\UniChatApplication\Views\UserProfile\UpdatePassword.cshtml"
                }
                else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"alert alert-danger alert-dismissible\">\n                        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\n                        <strong>");
#nullable restore
#line 46 "C:\Users\PhucHT\Desktop\UniChatWeb\UniChatApplication\Views\UserProfile\UpdatePassword.cshtml"
                           Write(TempData["UpdatePasswordMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\n                    </div>\n");
#nullable restore
#line 48 "C:\Users\PhucHT\Desktop\UniChatWeb\UniChatApplication\Views\UserProfile\UpdatePassword.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\PhucHT\Desktop\UniChatWeb\UniChatApplication\Views\UserProfile\UpdatePassword.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </div>
        <div class=""form-group"">
            <label for=""oldPassword"">Old Password</label>
            <input class=""form-control"" type=""password"" name=""oldPassword"" id=""oldPassword"" maxlength=""32"" required>
        </div>
        <div class=""form-group"">
            <label for=""newPassword"">New Password</label>
            <input class=""form-control"" type=""password"" name=""newPassword"" id=""newPassword"" maxlength=""32"" required>
        </div>
        <div class=""form-group"">
            <label for=""confirmPassword"">Confirm Password</label>
            <input class=""form-control"" type=""password"" name=""confirmPassword"" id=""confirmPassword"" maxlength=""32"" required>
        </div>

        <div class=""form-group"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6171593dfb2bc492d1a4dc9518e14b4e45cdabfb8978", async() => {
                    WriteLiteral("Back");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            <input type=\"submit\" value=\"Update\" class=\"button-1 text-white text-decoration-none\">\n        </div>\n\n    ");
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
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Account> Html { get; private set; }
    }
}
#pragma warning restore 1591
