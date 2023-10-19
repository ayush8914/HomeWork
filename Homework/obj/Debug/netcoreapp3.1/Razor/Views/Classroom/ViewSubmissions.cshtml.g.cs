#pragma checksum "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0cd5f50839e5bc0d14a65ef060a4cfb59ec216737f81b5220e47e7a5a2ad7a5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Classroom_ViewSubmissions), @"mvc.1.0.view", @"/Views/Classroom/ViewSubmissions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Classroom/ViewSubmissions.cshtml", typeof(AspNetCore.Views_Classroom_ViewSubmissions))]
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
#line 2 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\_ViewImports.cshtml"
using Blackboard.Models;

#line default
#line hidden
#line 3 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
using Blackboard;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0cd5f50839e5bc0d14a65ef060a4cfb59ec216737f81b5220e47e7a5a2ad7a5f", @"/Views/Classroom/ViewSubmissions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e23ccee953ac657259a3487acb720d5a597b5071a89d51b2b15d50dbc9a68614", @"/Views/_ViewImports.cshtml")]
    public class Views_Classroom_ViewSubmissions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blackboard.Models.SubmittedAssignment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-loadPartial", "Assignments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(148, 68, true);
            WriteLiteral("\n<div class=\"col-sm-10\">\n    <h3 style=\"background-color: #5a9191;\">");
            EndContext();
            BeginContext(217, 27, false);
#line 6 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
                                      Write(ViewData["AssignmentTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(244, 7, true);
            WriteLiteral("</h3>\n\n");
            EndContext();
#line 8 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden
            BeginContext(286, 33, true);
            WriteLiteral("        <span class=\"text-muted\">");
            EndContext();
            BeginContext(320, 24, false);
#line 10 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
                            Write(ViewData["EmptyMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(344, 23, true);
            WriteLiteral("</span>\n        <br />\n");
            EndContext();
#line 12 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
    }

#line default
#line hidden
#line 13 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
     foreach (var item in Model)
    {
        AppUser user = await _userManager.FindByIdAsync(item.AppUserID);

#line default
#line hidden
            BeginContext(485, 52, true);
            WriteLiteral("        <div class=\"content-block\">\n            <h6>");
            EndContext();
            BeginContext(538, 4, false);
#line 17 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
           Write(user);

#line default
#line hidden
            EndContext();
            BeginContext(542, 37, true);
            WriteLiteral("</h6>\n            <hr />\n            ");
            EndContext();
            BeginContext(580, 51, false);
#line 19 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
       Write(CustomHelpers.DisplayWithLinksFor(item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(631, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 20 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
             if (item.Files != null)
            {
                string[] files = item.Files.Split(",");
                if (files.Count() > 1 || (files.Count() == 1 && files[0].Length != 0))
                {

#line default
#line hidden
            BeginContext(844, 27, true);
            WriteLiteral("                    <hr />\n");
            EndContext();
#line 26 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
                }
                foreach (string file in files)
                {
                    if (file.Length == 0)
                    {
                        continue;
                    }
                    var filePath = "~/posted_assignments/" + file;
                    var filename = file.Substring(file.IndexOf("_") + 1, file.Length - file.IndexOf("_") - 1);
                    var fileUrl = "https://localhost:44300" + "/submitted_assignments/" + file;

#line default
#line hidden
            BeginContext(1348, 38, true);
            WriteLiteral("                    <a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1386, "\"", 1401, 1);
#line 36 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
WriteAttributeValue("", 1393, fileUrl, 1393, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1402, 26, true);
            WriteLiteral(">\n                        ");
            EndContext();
            BeginContext(1429, 8, false);
#line 37 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
                   Write(filename);

#line default
#line hidden
            EndContext();
            BeginContext(1437, 53, true);
            WriteLiteral("\n                    </a>\n                    <br />\n");
            EndContext();
#line 40 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(1522, 30, true);
            WriteLiteral("        </div>\n        <br />\n");
            EndContext();
#line 44 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
    }

#line default
#line hidden
#line 45 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
     if ((string)ViewData["Role"] == "Mentor")
    {

#line default
#line hidden
            BeginContext(1611, 85, true);
            WriteLiteral("        <br />\n        <div>\n            <h5>Students yet to submit this Assignment: ");
            EndContext();
            BeginContext(1697, 17, false);
#line 49 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
                                                   Write(ViewData["Count"]);

#line default
#line hidden
            EndContext();
            BeginContext(1714, 6, true);
            WriteLiteral("</h5>\n");
            EndContext();
#line 50 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
             foreach (ClassroomUser notSubmit in ViewBag.RemainingPeople)
            {

#line default
#line hidden
            BeginContext(1808, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(1828, 26, false);
#line 52 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
              Write(notSubmit.AppUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1854, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 53 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
            }

#line default
#line hidden
            BeginContext(1873, 15, true);
            WriteLiteral("        </div>\n");
            EndContext();
#line 55 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
    }

#line default
#line hidden
            BeginContext(1894, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1898, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cd5f50839e5bc0d14a65ef060a4cfb59ec216737f81b5220e47e7a5a2ad7a5f11015", async() => {
                BeginContext(1987, 13, true);
                WriteLiteral("Back to Class");
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
#line 56 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\ViewSubmissions.cshtml"
                           WriteLiteral(ViewBag.ClassId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-loadPartial", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["loadPartial"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2004, 138, true);
            WriteLiteral("\n</div>\n<style>\n    .content-block {\n        border: 1px solid #dddddd;\n        border-radius: 20px;\n        padding: 20px;\n    }\n</style>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Identity.UserManager<AppUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blackboard.Models.SubmittedAssignment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
