#pragma checksum "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d14c6b905d3ccf729f6c2833d902ef4b724cf4f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Details), @"mvc.1.0.view", @"/Views/Events/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Events/Details.cshtml", typeof(AspNetCore.Views_Events_Details))]
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
#line 1 "Z:\public_html\ASP\665Project_ASP\Views\_ViewImports.cshtml"
using _665Project_ASP;

#line default
#line hidden
#line 2 "Z:\public_html\ASP\665Project_ASP\Views\_ViewImports.cshtml"
using _665Project_ASP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d14c6b905d3ccf729f6c2833d902ef4b724cf4f7", @"/Views/Events/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9732c346cd60f243f508f163b5e9410984886831", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_665Project_ASP.Models.Events>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 129, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Events</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(213, 45, false);
#line 14 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EventName));

#line default
#line hidden
            EndContext();
            BeginContext(258, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(322, 41, false);
#line 17 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.EventName));

#line default
#line hidden
            EndContext();
            BeginContext(363, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(426, 46, false);
#line 20 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EventVenue));

#line default
#line hidden
            EndContext();
            BeginContext(472, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(536, 42, false);
#line 23 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.EventVenue));

#line default
#line hidden
            EndContext();
            BeginContext(578, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(641, 49, false);
#line 26 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EventDuration));

#line default
#line hidden
            EndContext();
            BeginContext(690, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(754, 45, false);
#line 29 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.EventDuration));

#line default
#line hidden
            EndContext();
            BeginContext(799, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(862, 45, false);
#line 32 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EventDate));

#line default
#line hidden
            EndContext();
            BeginContext(907, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(971, 41, false);
#line 35 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.EventDate));

#line default
#line hidden
            EndContext();
            BeginContext(1012, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1075, 47, false);
#line 38 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EventStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1186, 43, false);
#line 41 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.EventStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1292, 45, false);
#line 44 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EventType));

#line default
#line hidden
            EndContext();
            BeginContext(1337, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1401, 41, false);
#line 47 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.EventType));

#line default
#line hidden
            EndContext();
            BeginContext(1442, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1505, 45, false);
#line 50 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EventCity));

#line default
#line hidden
            EndContext();
            BeginContext(1550, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1614, 41, false);
#line 53 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.EventCity));

#line default
#line hidden
            EndContext();
            BeginContext(1655, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1718, 44, false);
#line 56 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EventZip));

#line default
#line hidden
            EndContext();
            BeginContext(1762, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1826, 40, false);
#line 59 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.EventZip));

#line default
#line hidden
            EndContext();
            BeginContext(1866, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1929, 52, false);
#line 62 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EventDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1981, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2045, 48, false);
#line 65 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.EventDescription));

#line default
#line hidden
            EndContext();
            BeginContext(2093, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2156, 50, false);
#line 68 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EventStartTime));

#line default
#line hidden
            EndContext();
            BeginContext(2206, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2270, 46, false);
#line 71 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.EventStartTime));

#line default
#line hidden
            EndContext();
            BeginContext(2316, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2379, 50, false);
#line 74 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EventOrganizer));

#line default
#line hidden
            EndContext();
            BeginContext(2429, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2493, 54, false);
#line 77 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.EventOrganizer.EmailId));

#line default
#line hidden
            EndContext();
            BeginContext(2547, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2594, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d14c6b905d3ccf729f6c2833d902ef4b724cf4f713151", async() => {
                BeginContext(2645, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "Z:\public_html\ASP\665Project_ASP\Views\Events\Details.cshtml"
                           WriteLiteral(Model.EventId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2653, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2661, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d14c6b905d3ccf729f6c2833d902ef4b724cf4f715460", async() => {
                BeginContext(2683, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2699, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_665Project_ASP.Models.Events> Html { get; private set; }
    }
}
#pragma warning restore 1591
