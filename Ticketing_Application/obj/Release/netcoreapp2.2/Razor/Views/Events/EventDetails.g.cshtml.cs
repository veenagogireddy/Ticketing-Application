#pragma checksum "Z:\public_html\ASP\665Project_ASP\Views\Events\EventDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf41c3bb14a2c7d1cf736c77006480c61f778d14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_EventDetails), @"mvc.1.0.view", @"/Views/Events/EventDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Events/EventDetails.cshtml", typeof(AspNetCore.Views_Events_EventDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf41c3bb14a2c7d1cf736c77006480c61f778d14", @"/Views/Events/EventDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9732c346cd60f243f508f163b5e9410984886831", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_EventDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_665Project_ASP.Models.Events>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApproveDenyEvents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "Z:\public_html\ASP\665Project_ASP\Views\Events\EventDetails.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 35, true);
            WriteLiteral("\r\n<h1>Event Details</h1>\r\n\r\n<div>\r\n");
            EndContext();
            BeginContext(143, 65, true);
            WriteLiteral("    <br />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n");
            EndContext();
            BeginContext(272, 83, true);
            WriteLiteral("            Event Name\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(356, 41, false);
#line 18 "Z:\public_html\ASP\665Project_ASP\Views\Events\EventDetails.cshtml"
       Write(Html.DisplayFor(model => model.EventName));

#line default
#line hidden
            EndContext();
            BeginContext(397, 132, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Event Venue\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(530, 42, false);
#line 24 "Z:\public_html\ASP\665Project_ASP\Views\Events\EventDetails.cshtml"
       Write(Html.DisplayFor(model => model.EventVenue));

#line default
#line hidden
            EndContext();
            BeginContext(572, 135, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Event Duration\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(708, 45, false);
#line 30 "Z:\public_html\ASP\665Project_ASP\Views\Events\EventDetails.cshtml"
       Write(Html.DisplayFor(model => model.EventDuration));

#line default
#line hidden
            EndContext();
            BeginContext(753, 131, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Event Date\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(885, 35, false);
#line 36 "Z:\public_html\ASP\665Project_ASP\Views\Events\EventDetails.cshtml"
       Write(Model.EventDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(920, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(982, 131, true);
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Event Status\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1114, 43, false);
#line 43 "Z:\public_html\ASP\665Project_ASP\Views\Events\EventDetails.cshtml"
       Write(Html.DisplayFor(model => model.EventStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 131, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Event Type\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1289, 41, false);
#line 49 "Z:\public_html\ASP\665Project_ASP\Views\Events\EventDetails.cshtml"
       Write(Html.DisplayFor(model => model.EventType));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 131, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Event City\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1462, 41, false);
#line 55 "Z:\public_html\ASP\665Project_ASP\Views\Events\EventDetails.cshtml"
       Write(Html.DisplayFor(model => model.EventCity));

#line default
#line hidden
            EndContext();
            BeginContext(1503, 130, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Event Zip\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1634, 40, false);
#line 61 "Z:\public_html\ASP\665Project_ASP\Views\Events\EventDetails.cshtml"
       Write(Html.DisplayFor(model => model.EventZip));

#line default
#line hidden
            EndContext();
            BeginContext(1674, 138, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Event Description\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1813, 48, false);
#line 67 "Z:\public_html\ASP\665Project_ASP\Views\Events\EventDetails.cshtml"
       Write(Html.DisplayFor(model => model.EventDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1861, 137, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Event Start Time\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1999, 46, false);
#line 73 "Z:\public_html\ASP\665Project_ASP\Views\Events\EventDetails.cshtml"
       Write(Html.DisplayFor(model => model.EventStartTime));

#line default
#line hidden
            EndContext();
            BeginContext(2045, 134, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Host Email ID\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2180, 54, false);
#line 79 "Z:\public_html\ASP\665Project_ASP\Views\Events\EventDetails.cshtml"
       Write(Html.DisplayFor(model => model.EventOrganizer.EmailId));

#line default
#line hidden
            EndContext();
            BeginContext(2234, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2281, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf41c3bb14a2c7d1cf736c77006480c61f778d149942", async() => {
                BeginContext(2339, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(2355, 10, true);
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
