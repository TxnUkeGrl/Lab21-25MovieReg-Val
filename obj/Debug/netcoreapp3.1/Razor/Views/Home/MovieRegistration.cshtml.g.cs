#pragma checksum "D:\GCProjects\Labs & HW\Lab21MovieRegistration\Views\Home\MovieRegistration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dc771377824a423064b030ad31ffab622689a96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MovieRegistration), @"mvc.1.0.view", @"/Views/Home/MovieRegistration.cshtml")]
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
#line 1 "D:\GCProjects\Labs & HW\Lab21MovieRegistration\Views\_ViewImports.cshtml"
using Lab21MovieRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GCProjects\Labs & HW\Lab21MovieRegistration\Views\_ViewImports.cshtml"
using Lab21MovieRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dc771377824a423064b030ad31ffab622689a96", @"/Views/Home/MovieRegistration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e87cd11af520fe5972849a56461d06e65083e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieRegistration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Results", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\GCProjects\Labs & HW\Lab21MovieRegistration\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dc771377824a423064b030ad31ffab622689a964408", async() => {
                WriteLiteral("\r\n    Title:<br />\r\n    <input type=\"text\" name=\"Title\"");
                BeginWriteAttribute("value", " value=\"", 163, "\"", 171, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Movie Title\" />\r\n    ");
#nullable restore
#line 8 "D:\GCProjects\Labs & HW\Lab21MovieRegistration\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationMessageFor(x => x.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n\r\n    Genre:<br />\r\n   ");
#nullable restore
#line 12 "D:\GCProjects\Labs & HW\Lab21MovieRegistration\Views\Home\MovieRegistration.cshtml"
Write(Html.DropDownList("ListGenre"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("    <!--<div class=\"form-group\">\r\n        Html.DropDownList(\"ListGenre\",)-->\r\n");
                WriteLiteral(@"    <!--<select asp-for=""Genre"">
            <option value="""">Action/Adventure</option>
            <option value=""Animated"">Animated</option>
            <option value=""Children/Family"">Children/Family</option>
            <option value=""Comedy"">Comedy</option>
            <option value=""Drama"">Drama</option>
            <option value=""Fiction/Fantasy"">Fiction/Fantasy</option>
            <option value=""Horror"">Horror</option>
            <option value=""Musical"">Musical</option>
            <option value=""Romance"">Romance</option>
            <option value=""Western"">Western</option>
            <option value=""Genre not Listed"">Genre not Listed</option>
        </select>
    </div>-->
    ");
#nullable restore
#line 31 "D:\GCProjects\Labs & HW\Lab21MovieRegistration\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationMessageFor(x => x.Genre));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n\r\n    Year:<br />\r\n    <input type=\"text\" name=\"Year\"");
                BeginWriteAttribute("value", " value=\"", 1350, "\"", 1358, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Year Released\" />\r\n    ");
#nullable restore
#line 35 "D:\GCProjects\Labs & HW\Lab21MovieRegistration\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationMessageFor(x => x.Year));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n\r\n    Actors: <br />\r\n    <input type=\"text\" name=\"Actors\"");
                BeginWriteAttribute("value", " value=\"", 1507, "\"", 1515, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Leading Actor(s)\" />\r\n    ");
#nullable restore
#line 40 "D:\GCProjects\Labs & HW\Lab21MovieRegistration\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationMessageFor(x => x.Actors));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n\r\n    Directors: <br />\r\n    <input type=\"text\" name=\"Directors\"");
                BeginWriteAttribute("value", " value=\"", 1675, "\"", 1683, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Head Director\" />\r\n    ");
#nullable restore
#line 45 "D:\GCProjects\Labs & HW\Lab21MovieRegistration\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationMessageFor(x => x.Directors));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n\r\n    ID: <br />\r\n    <input type=\"text\" name=\"ID\"");
                BeginWriteAttribute("value", " value=\"", 1829, "\"", 1837, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"ID #\" />\r\n    ");
#nullable restore
#line 50 "D:\GCProjects\Labs & HW\Lab21MovieRegistration\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationMessageFor(x => x.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n\r\n    <br />\r\n");
                WriteLiteral("    <input type=\"submit\" value=\"Submit\" class=\"submit\" /><br />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
