#pragma checksum "C:\git\ownSamples\MVC Seminar\day 2\HelloMVCSample\HelloMVCSample\Views\Shared\_CommentDisplay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2a68eb03c4cb8d9033e93385ab81a3d029262ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CommentDisplay), @"mvc.1.0.view", @"/Views/Shared/_CommentDisplay.cshtml")]
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
#line 1 "C:\git\ownSamples\MVC Seminar\day 2\HelloMVCSample\HelloMVCSample\Views\_ViewImports.cshtml"
using HelloMVCSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\ownSamples\MVC Seminar\day 2\HelloMVCSample\HelloMVCSample\Views\_ViewImports.cshtml"
using HelloMVCSample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2a68eb03c4cb8d9033e93385ab81a3d029262ce", @"/Views/Shared/_CommentDisplay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58ad92e2e42fa18c6aa6274e660600208e8815d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CommentDisplay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelloMVCSample.Models.CommentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <small>");
#nullable restore
#line 4 "C:\git\ownSamples\MVC Seminar\day 2\HelloMVCSample\HelloMVCSample\Views\Shared\_CommentDisplay.cshtml"
      Write(ViewData["PageTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n");
#nullable restore
#line 5 "C:\git\ownSamples\MVC Seminar\day 2\HelloMVCSample\HelloMVCSample\Views\Shared\_CommentDisplay.cshtml"
       ViewData["PageTitle"] = "Dummy!"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 8 "C:\git\ownSamples\MVC Seminar\day 2\HelloMVCSample\HelloMVCSample\Views\Shared\_CommentDisplay.cshtml"
       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 11 "C:\git\ownSamples\MVC Seminar\day 2\HelloMVCSample\HelloMVCSample\Views\Shared\_CommentDisplay.cshtml"
       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\git\ownSamples\MVC Seminar\day 2\HelloMVCSample\HelloMVCSample\Views\Shared\_CommentDisplay.cshtml"
       Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\git\ownSamples\MVC Seminar\day 2\HelloMVCSample\HelloMVCSample\Views\Shared\_CommentDisplay.cshtml"
       Write(Html.DisplayFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\git\ownSamples\MVC Seminar\day 2\HelloMVCSample\HelloMVCSample\Views\Shared\_CommentDisplay.cshtml"
       Write(Html.DisplayNameFor(model => model.Posted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\git\ownSamples\MVC Seminar\day 2\HelloMVCSample\HelloMVCSample\Views\Shared\_CommentDisplay.cshtml"
       Write(Html.DisplayFor(model => model.Posted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <small>");
#nullable restore
#line 26 "C:\git\ownSamples\MVC Seminar\day 2\HelloMVCSample\HelloMVCSample\Views\Shared\_CommentDisplay.cshtml"
      Write(ViewData["PageTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n</div>\r\n<!--<div>-->\r\n");
            WriteLiteral("    <!--<a asp-action=\"Index\">Back to List</a>\r\n</div>-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelloMVCSample.Models.CommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
