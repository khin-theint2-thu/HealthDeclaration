#pragma checksum "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\HealthDeclarationForm\ViewList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9acd4414c9629a153fdd408aeea8ffa62f4f07c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HealthDeclarationForm_ViewList), @"mvc.1.0.view", @"/Views/HealthDeclarationForm/ViewList.cshtml")]
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
#line 1 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\_ViewImports.cshtml"
using CovidHealthDeclarationForm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\_ViewImports.cshtml"
using CovidHealthDeclarationForm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9acd4414c9629a153fdd408aeea8ffa62f4f07c3", @"/Views/HealthDeclarationForm/ViewList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c966fbf10abf3a2c0e27195e300b202ead1aa5bb", @"/Views/_ViewImports.cshtml")]
    public class Views_HealthDeclarationForm_ViewList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CovidHealthDeclarationForm.Models.HealthDeclarationData>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/nace-town-halls-covid-19.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("260"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"panel panel-default mt-2\">\r\n        <div class=\"panel-header\">\r\n            <a href=\"/HealthDeclarationForm\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9acd4414c9629a153fdd408aeea8ffa62f4f07c34645", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("href", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </a>
            <span class=""main-header-title"">HEALTH DECLARATION</span>
        </div>
        <table class=""table mt-2"" id=""hdecldata_table"">
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Email</th>
                    <th>Phone</th>
                    <th>Address</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 22 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\HealthDeclarationForm\ViewList.cshtml"
                 foreach (var hdecl in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr data-url=\"Detail?visitorid=");
#nullable restore
#line 25 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\HealthDeclarationForm\ViewList.cshtml"
                                              Write(hdecl.VisitorID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <td>");
#nullable restore
#line 26 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\HealthDeclarationForm\ViewList.cshtml"
                       Write(hdecl.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\HealthDeclarationForm\ViewList.cshtml"
                       Write(hdecl.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\HealthDeclarationForm\ViewList.cshtml"
                       Write(hdecl.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\HealthDeclarationForm\ViewList.cshtml"
                       Write(hdecl.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 31 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\HealthDeclarationForm\ViewList.cshtml"
                       Write(hdecl.BuildingName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 32 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\HealthDeclarationForm\ViewList.cshtml"
                       Write(string.Concat(string.IsNullOrEmpty(hdecl.BuildingLevel) ? "" : "-" + hdecl.BuildingLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 33 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\HealthDeclarationForm\ViewList.cshtml"
                       Write(string.Concat(string.IsNullOrEmpty(hdecl.StreetName) ? "" : "-" + hdecl.StreetName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 34 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\HealthDeclarationForm\ViewList.cshtml"
                       Write(string.Concat(string.IsNullOrEmpty(hdecl.RoomNumber) ? "" : "-" + hdecl.RoomNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 35 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\HealthDeclarationForm\ViewList.cshtml"
                       Write(string.Concat(string.IsNullOrEmpty(hdecl.Carpark) ? "" : "-" + hdecl.Carpark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 36 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\HealthDeclarationForm\ViewList.cshtml"
                       Write(string.Concat(string.IsNullOrEmpty(hdecl.Lobby) ? "" : "-" + hdecl.Lobby));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 37 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\HealthDeclarationForm\ViewList.cshtml"
                       Write(string.Concat(string.IsNullOrEmpty(hdecl.Pantry) ? "" : "-" + hdecl.Pantry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 38 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\HealthDeclarationForm\ViewList.cshtml"
                       Write(string.Concat(string.IsNullOrEmpty(hdecl.PostalCode) ? "" : "-" + hdecl.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 42 "D:\KhinTheint\CovidHealthDeclarationForm\CovidHealthDeclarationForm\CovidHealthDeclarationForm\Views\HealthDeclarationForm\ViewList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

<script>
    $('#hdecldata_table tbody').on('click', 'tr', function () {
        var url = $(this).data('url');
        window.location.href = url;
    });

    $('#hdecldata_table').DataTable({});
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CovidHealthDeclarationForm.Models.HealthDeclarationData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
