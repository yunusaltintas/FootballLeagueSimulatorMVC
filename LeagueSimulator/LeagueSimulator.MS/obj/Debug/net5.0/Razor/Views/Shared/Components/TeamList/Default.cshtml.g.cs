#pragma checksum "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\TeamList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e55b2a27d1d2166f89ab37e852eaf3dfd0f50c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TeamList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TeamList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e55b2a27d1d2166f89ab37e852eaf3dfd0f50c5", @"/Views/Shared/Components/TeamList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TeamList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LeagueSimulator.Data.ResponseModel.ReturnParameterModel<List<LeagueSimulator.Data.Entities.Team>>>
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
            WriteLiteral("<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e55b2a27d1d2166f89ab37e852eaf3dfd0f50c53136", async() => {
                WriteLiteral("\r\n    <title></title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e55b2a27d1d2166f89ab37e852eaf3dfd0f50c54125", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\TeamList\Default.cshtml"
     if (Model.Success == true)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <h3 class=""text-center"">Teams</h3>
        <table class=""table table-sm table-bordered table-hover mt-3"">
            <tr>
                <th>Teams Name</th>
                <th>Attack</th>
                <th>Defense</th>
                <th>Chance</th>

            </tr>
");
#nullable restore
#line 18 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\TeamList\Default.cshtml"
             foreach (var item in Model.Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\TeamList\Default.cshtml"
                   Write(item.TeamName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\TeamList\Default.cshtml"
                   Write(item.Attack);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\TeamList\Default.cshtml"
                   Write(item.Defense);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\TeamList\Default.cshtml"
                   Write(item.Chance);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\TeamList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </table>\r\n");
#nullable restore
#line 33 "C:\Users\yunus\source\repos\GİT\FootballLeagueSimulator\LeagueSimulator\LeagueSimulator.MS\Views\Shared\Components\TeamList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeagueSimulator.Data.ResponseModel.ReturnParameterModel<List<LeagueSimulator.Data.Entities.Team>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
