#pragma checksum "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\Home.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "69c8d07b26485d1364bccea03fcc4cb8e3844ed2c7f7bff73c0ff3a7e8201f6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Classroom_Home), @"mvc.1.0.view", @"/Views/Classroom/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Classroom/Home.cshtml", typeof(AspNetCore.Views_Classroom_Home))]
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
#line 1 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\_ViewImports.cshtml"
using Blackboard;

#line default
#line hidden
#line 2 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\_ViewImports.cshtml"
using Blackboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"69c8d07b26485d1364bccea03fcc4cb8e3844ed2c7f7bff73c0ff3a7e8201f6e", @"/Views/Classroom/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e23ccee953ac657259a3487acb720d5a597b5071a89d51b2b15d50dbc9a68614", @"/Views/_ViewImports.cshtml")]
    public class Views_Classroom_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blackboard.ViewModels.ClassroomHomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LeaveClassroom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BlackBoardIndexPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AssignmentPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PeoplePartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(53, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\Home.cshtml"
  
    ViewData["Title"] = "Home";
    ViewData["ClassId"] = Model.Classroom.ID;

#line default
#line hidden
            BeginContext(137, 111, true);
            WriteLiteral("<div class=\"row h-100 w-100 mb-3\" style=\"background-color: #b0cfc7\">\n\t\n    <div class=\"col-md-12\">\n        <h2>");
            EndContext();
            BeginContext(249, 47, false);
#line 11 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\Home.cshtml"
       Write(Html.DisplayFor(model => model.Classroom.title));

#line default
#line hidden
            EndContext();
            BeginContext(296, 17, true);
            WriteLiteral("</h2>\n        <p>");
            EndContext();
            BeginContext(314, 62, false);
#line 12 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\Home.cshtml"
      Write(CustomHelpers.DisplayWithLinksFor(Model.Classroom.description));

#line default
#line hidden
            EndContext();
            BeginContext(376, 1234, true);
            WriteLiteral(@"</p>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-2"">
        <nav class=""d-none d-md-block bg-light sidebar"">
        <div class=""sidebar-sticky"">
            <h6 class=""sidebar-heading d-flex justify-content-between align-items-center px-3 mt-4 mb-1 text-muted"">
                <span>Room</span>
            </h6>
            <ul class=""nav flex-column"">
                <li class=""nav-item"">
                    <button class=""nav-link btn test btn-custom"" id=""ViewBoard"">
                        Black Board
                    </button>
                </li>
                <li class=""nav-item"">
                    <button class=""nav-link btn test btn-custom"" id=""ViewAssignments"">
                        Assignments
                    </button>
                </li>
                <li class=""nav-item"">
                    <button class=""nav-link btn test btn-custom"" id=""ViewPeople"">
                        People
                    </button>
                </li>
            </ul>

          ");
            WriteLiteral("  <h6 class=\"sidebar-heading d-flex justify-content-between align-items-center px-3 mt-4 mb-1 text-muted\">\n                <span>Settings</span>\n            </h6>\n\n            <ul class=\"nav flex-column mb-2\">\n");
            EndContext();
#line 45 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\Home.cshtml"
                 if (Model.ClassroomUserRole == "Mentor")
                {

#line default
#line hidden
            BeginContext(1686, 66, true);
            WriteLiteral("                    <li class=\"nav-item\">\n                        ");
            EndContext();
            BeginContext(1752, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c8d07b26485d1364bccea03fcc4cb8e3844ed2c7f7bff73c0ff3a7e8201f6e8634", async() => {
                BeginContext(1825, 64, true);
                WriteLiteral("\n                            Edit Class\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\Home.cshtml"
                                                                WriteLiteral(Model.Classroom.ID);

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
            BeginContext(1893, 1068, true);
            WriteLiteral(@"
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link text-danger"" style=""cursor:pointer;"" data-toggle=""modal"" data-target=""#DeleteModal"">
                            Delete Class
                        </a>
                    </li>
                    <div class=""modal fade"" id=""DeleteModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""DeleteModalLabel"" aria-hidden=""true"">
                        <div class=""modal-dialog"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                        <h5 class=""modal-title"">Hold Up!</h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                <div class=""modal");
            WriteLiteral("-body\">\n                                    ");
            EndContext();
            BeginContext(2961, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69c8d07b26485d1364bccea03fcc4cb8e3844ed2c7f7bff73c0ff3a7e8201f6e12311", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 67 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\Home.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3008, 133, true);
            WriteLiteral("\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n");
            EndContext();
#line 72 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\Home.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3198, 1085, true);
            WriteLiteral(@"                    <li class=""nav-item"">
                        <a class=""nav-link text-danger"" data-toggle=""modal"" data-target=""#LeaveModal"">
                            Leave Class
                        </a>
                    </li>
                    <div class=""modal fade"" id=""LeaveModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""DeleteModalLabel"" aria-hidden=""true"">
                        <div class=""modal-dialog"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                        <h5 class=""modal-title"" style=""background-color: #5a9191; border-color: #5a9191; color: white"">Hold Up!</h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                ");
            WriteLiteral("<div class=\"modal-body\">\n                                    ");
            EndContext();
            BeginContext(4283, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69c8d07b26485d1364bccea03fcc4cb8e3844ed2c7f7bff73c0ff3a7e8201f6e15601", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 90 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\Home.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4338, 133, true);
            WriteLiteral("\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n");
            EndContext();
#line 95 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\Home.cshtml"
                }

#line default
#line hidden
            BeginContext(4489, 132, true);
            WriteLiteral("            </ul>\n\n        </div>\n    </nav>\n\n    </div>\n    <div class=\"mt-3 col-md-10\">\n        <div id=\"BlackBoard\">\n            ");
            EndContext();
            BeginContext(4621, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69c8d07b26485d1364bccea03fcc4cb8e3844ed2c7f7bff73c0ff3a7e8201f6e17833", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 104 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\Home.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4684, 59, true);
            WriteLiteral("\n        </div>\n        <div id=\"Assignments\">\n            ");
            EndContext();
            BeginContext(4743, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69c8d07b26485d1364bccea03fcc4cb8e3844ed2c7f7bff73c0ff3a7e8201f6e19603", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 107 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\Home.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4801, 54, true);
            WriteLiteral("\n        </div>\n        <div id=\"People\">\n            ");
            EndContext();
            BeginContext(4855, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69c8d07b26485d1364bccea03fcc4cb8e3844ed2c7f7bff73c0ff3a7e8201f6e21368", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 110 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\Home.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4909, 543, true);
            WriteLiteral(@"
        </div>
    </div>
</div>

<script>
    window.onscroll = function() {myFunction()};
    var header = document.getElementsByClassName(""sidebar"")[0];
    var sticky = header.offsetTop;
    function myFunction() {
        if (window.pageYOffset > 190) {
            header.classList.add(""custom-sticky"");
        } else {
            header.classList.remove(""custom-sticky"");
        }
    }
    $(document).ready(function () {

        $(""#BlackBoard"").hide();
        $(""#People"").hide();
        $(""#Assignments"").hide();
        $(""#");
            EndContext();
            BeginContext(5453, 23, false);
#line 131 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Views\Classroom\Home.cshtml"
       Write(ViewData["loadPartial"]);

#line default
#line hidden
            EndContext();
            BeginContext(5476, 1645, true);
            WriteLiteral(@""").show();
        $(""#ViewBoard"").click(function () {
            $(""#BlackBoard"").show();
            $(""#People"").hide();
            $(""#Assignments"").hide();
        });

        $(""#ViewAssignments"").click(function () {
            $(""#BlackBoard"").hide();
            $(""#People"").hide();
            $(""#Assignments"").show();
        });

        $(""#ViewPeople"").click(function () {
            $(""#BlackBoard"").hide();
            $(""#People"").show();
            $(""#Assignments"").hide();
        });
    });
</script>

<style>
    .btn.active.focus, .btn.active:focus, .btn.focus, .btn.focus:active, .btn:active:focus, .btn:focus {
        outline: thin dotted;
        outline-offset: -2px;
    }

    .test:focus {
        outline: none !important;
        border-color: transparent !important;
    }

    .btn-custom {
        color: #000;
        background-color: #f8f9fa;
    }

        .btn-custom:hover {
            color: #fff;
            background-color: #5a9191;
        }

        .btn-custom:focu");
            WriteLiteral(@"s, .btn-custom.focus {
            color: #fff;
            background-color: #5a9191;
        }

    body .btn {
        outline: 0;
    }

    .btn.active.focus,
    .btn.active:focus,
    .btn.focus,
    .btn.focus:active,
    .btn:active:focus,
    .btn:focus {
        outline: 0;
        outline-offset: 0;
        background-image: none;
        -webkit-box-shadow: none;
        box-shadow: none;
    }

    .light-grey-display {
        background-color: #eeeeee !important;
        padding: 10px;
        border-radius: 5px;
    }

    .custom-sticky{
        position:fixed;
        top:0;
    }

</style>




");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blackboard.ViewModels.ClassroomHomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
