#pragma checksum "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\PredictionCamp\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce763990f5ba273ba6e86cb8298edec2dcae1498"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PredictionCamp_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PredictionCamp/Default.cshtml")]
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
#line 1 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\_ViewImports.cshtml"
using LeagueSimulator.Data.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\_ViewImports.cshtml"
using LeagueSimulator.Core.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce763990f5ba273ba6e86cb8298edec2dcae1498", @"/Views/Shared/Components/PredictionCamp/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10f269357628345839be668610ec55cb5be87959", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PredictionCamp_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PredictionChampWithTeamDTO>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\PredictionCamp\Default.cshtml"
 if (4 <= ViewBag.week)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce763990f5ba273ba6e86cb8298edec2dcae14983834", async() => {
                WriteLiteral("\r\n        <title></title>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce763990f5ba273ba6e86cb8298edec2dcae14984835", async() => {
                WriteLiteral("\r\n        <h5>");
#nullable restore
#line 9 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\PredictionCamp\Default.cshtml"
       Write(ViewBag.week);

#line default
#line hidden
#nullable disable
                WriteLiteral(" .Week Predictions Of Campionship</h5>\r\n        <table class=\"table table-sm table-bordered table-hover mt-3\">\r\n            <tr>\r\n                <th>Teams Name</th>\r\n                <th>Prediction</th>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 16 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\PredictionCamp\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\PredictionCamp\Default.cshtml"
                   Write(item.Team.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>%");
#nullable restore
#line 20 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\PredictionCamp\Default.cshtml"
                    Write(item.Prediction);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 23 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\PredictionCamp\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </table>\r\n\r\n\r\n    ");
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
            WriteLiteral("\r\n</html>\r\n");
#nullable restore
#line 30 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\PredictionCamp\Default.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PredictionChampWithTeamDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591