#pragma checksum "C:\Project\ASPNETCore2x\Globoma\Globoma\Views\Proposal\DisplayTemplates\ProposalModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f34b256ff4c94f55f1803625be00b3859098440"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proposal_DisplayTemplates_ProposalModel), @"mvc.1.0.view", @"/Views/Proposal/DisplayTemplates/ProposalModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Proposal/DisplayTemplates/ProposalModel.cshtml", typeof(AspNetCore.Views_Proposal_DisplayTemplates_ProposalModel))]
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
#line 1 "C:\Project\ASPNETCore2x\Globoma\Globoma\Views\Proposal\DisplayTemplates\ProposalModel.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 2 "C:\Project\ASPNETCore2x\Globoma\Globoma\Views\Proposal\DisplayTemplates\ProposalModel.cshtml"
using Globoma;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f34b256ff4c94f55f1803625be00b3859098440", @"/Views/Proposal/DisplayTemplates/ProposalModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cfabe0b49a2ea3b364ec6f27b5c32b3c3b437b", @"/Views/_ViewImports.cshtml")]
    public class Views_Proposal_DisplayTemplates_ProposalModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shared.Models.ProposalModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Approve", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(89, 16, true);
            WriteLiteral("\r\n<tr>\r\n    <td>");
            EndContext();
            BeginContext(106, 11, false);
#line 6 "C:\Project\ASPNETCore2x\Globoma\Globoma\Views\Proposal\DisplayTemplates\ProposalModel.cshtml"
   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(117, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(133, 13, false);
#line 7 "C:\Project\ASPNETCore2x\Globoma\Globoma\Views\Proposal\DisplayTemplates\ProposalModel.cshtml"
   Write(Model.Speaker);

#line default
#line hidden
            EndContext();
            BeginContext(146, 17, true);
            WriteLiteral("</td>\r\n    <td>\r\n");
            EndContext();
#line 9 "C:\Project\ASPNETCore2x\Globoma\Globoma\Views\Proposal\DisplayTemplates\ProposalModel.cshtml"
         if (Model.Approved)
        {

#line default
#line hidden
            BeginContext(204, 59, true);
            WriteLiteral("            <div class=\"glyphicon glyphicon-check\"></div>\r\n");
            EndContext();
#line 12 "C:\Project\ASPNETCore2x\Globoma\Globoma\Views\Proposal\DisplayTemplates\ProposalModel.cshtml"
        }

#line default
#line hidden
            BeginContext(274, 21, true);
            WriteLiteral("    </td>\r\n    <td>\r\n");
            EndContext();
#line 15 "C:\Project\ASPNETCore2x\Globoma\Globoma\Views\Proposal\DisplayTemplates\ProposalModel.cshtml"
         if (!Model.Approved)
        {

#line default
#line hidden
            BeginContext(337, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(349, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea0797e35ff4a7c9ad6507731d3a8c2", async() => {
                BeginContext(406, 7, true);
                WriteLiteral("Approve");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-proposalId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Project\ASPNETCore2x\Globoma\Globoma\Views\Proposal\DisplayTemplates\ProposalModel.cshtml"
                                              WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["proposalId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-proposalId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["proposalId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(417, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "C:\Project\ASPNETCore2x\Globoma\Globoma\Views\Proposal\DisplayTemplates\ProposalModel.cshtml"
        }

#line default
#line hidden
            BeginContext(430, 16, true);
            WriteLiteral("    </td>\r\n</tr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shared.Models.ProposalModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
