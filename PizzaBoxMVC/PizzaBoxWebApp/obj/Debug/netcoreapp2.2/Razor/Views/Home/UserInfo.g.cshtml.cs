#pragma checksum "C:\Revature\Projects\Project_01\Emmanuel_Ruscalleda_Prj01\PizzaBoxMVC\PizzaBoxWebApp\Views\Home\UserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d0cfb770f99c98a38eebd5a8e2e53c18c0bc99f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserInfo), @"mvc.1.0.view", @"/Views/Home/UserInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserInfo.cshtml", typeof(AspNetCore.Views_Home_UserInfo))]
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
#line 1 "C:\Revature\Projects\Project_01\Emmanuel_Ruscalleda_Prj01\PizzaBoxMVC\PizzaBoxWebApp\Views\_ViewImports.cshtml"
using PizzaBoxWebApp;

#line default
#line hidden
#line 2 "C:\Revature\Projects\Project_01\Emmanuel_Ruscalleda_Prj01\PizzaBoxMVC\PizzaBoxWebApp\Views\_ViewImports.cshtml"
using PizzaBoxWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d0cfb770f99c98a38eebd5a8e2e53c18c0bc99f", @"/Views/Home/UserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"980b45478c11c226000b2ff6cb7208f955fc5b96", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/ComingSoon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Revature\Projects\Project_01\Emmanuel_Ruscalleda_Prj01\PizzaBoxMVC\PizzaBoxWebApp\Views\Home\UserInfo.cshtml"
  
    ViewData["Title"] = "User Info";

#line default
#line hidden
            BeginContext(47, 31, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(78, 1748, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d0cfb770f99c98a38eebd5a8e2e53c18c0bc99f4567", async() => {
                BeginContext(84, 131, true);
                WriteLiteral("\r\n\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Create account</h1>\r\n        <h1>PizzaBox</h1>\r\n    </div>\r\n\r\n    ");
                EndContext();
                BeginContext(215, 1600, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d0cfb770f99c98a38eebd5a8e2e53c18c0bc99f5096", async() => {
                    BeginContext(261, 1547, true);
                    WriteLiteral(@"
        <h2>Personal Information</h2>
        Password:<br> <input type=""password"" name=""password1"" maxlength=""50"" minlength=""8"" required><br>
        Re-enter Password:<br> <input type=""password"" name=""password2"" maxlength=""50"" minlength=""8"" required><br>
        <br>
        <br>
        First Name:<br> <input type=""text"" name=""fname"" ><br>
        Last Name:<br> <input type=""text"" name=""lname""><br>
        Address 1:<br> <input type=""text"" name=""address1""><br>
        Address 2:<br> <input type=""text"" name=""address2"" placeholder=""optional""><br>
        City:<br> <input type=""text"" name=""city""><br>
        State:<br> <input type=""text"" name=""state""><br>
        Zip-code:<br> <input type=""text"" name=""zipcode"" pattern=""[0-9]{5}"" placeholder=""#####""><br>
        Phone:<br> <input type=""tel"" name=""phone"" pattern=""[0-9]{3}-[0-9]{3}-[0-9]{4}"" placeholder=""###-###-####""><br>
        <br>
        <br>
        <h2>Billing Information</h2>
        Card Number:<br> <input type=""text"" name=""cardnumber");
                    WriteLiteral(@""" pattern=""[0-9]{4}-[0-9]{4}-[0-9]{4}-[0-9]{4}"" placeholder=""####-####-####-####""><br>
        CVV:<br> <input type=""text"" name=""cvv"" pattern=""[0-9]{3}"" placeholder=""###""><br>
        Valid Thru:<br> <input type=""date"" name=""validthru""><br>
        <br>
        <h6>Name as show in card:</h6>
        First Name:<br> <input type=""text"" name=""cardfname""><br>
        Last Name:<br> <input type=""text"" name=""cardlname""><br>
        <br>
        <br>
        <br>
        <input type=""submit"" value=""Submit"">

    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1815, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1826, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591