#pragma checksum "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2976758dbf64d7b9549f82b1b38211a04e2c1c92518a1db33a102fc79d76ece2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_ShowRecoveryCodes), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/ShowRecoveryCodes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Manage/ShowRecoveryCodes.cshtml", typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_ShowRecoveryCodes), null)]
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
#line 1 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Areas\Identity\Pages\_ViewImports.cshtml"
using Blackboard.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Areas\Identity\Pages\_ViewImports.cshtml"
using Blackboard.Areas.Identity.Pages;

#line default
#line hidden
#line 1 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Blackboard.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using Blackboard.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2976758dbf64d7b9549f82b1b38211a04e2c1c92518a1db33a102fc79d76ece2", @"/Areas/Identity/Pages/Account/Manage/ShowRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"28cdb9a09c4afed96e86da9424ca7b5913c8c92a2367afc3dd5230a87468392d", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4757b41947ba725976c82166bf5748771fe81af6ea572bf23ffe61c1a8e82653", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a6516081f52db73c2dd5cf10565d84891011697b6b77cc916596f6923d33ca4e", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_ShowRecoveryCodes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
  
    ViewData["Title"] = "Recovery codes";
    ViewData["ActivePage"] = "TwoFactorAuthentication";

#line default
#line hidden
            BeginContext(139, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(140, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2976758dbf64d7b9549f82b1b38211a04e2c1c92518a1db33a102fc79d76ece25226", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 8 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StatusMessage);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(193, 5, true);
            WriteLiteral("\n<h4>");
            EndContext();
            BeginContext(199, 17, false);
#line 9 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(216, 302, true);
            WriteLiteral(@"</h4>
<div class=""alert alert-warning"" role=""alert"">
    <p>
        <strong>Put these codes in a safe place.</strong>
    </p>
    <p>
        If you lose your device and don't have the recovery codes you will lose access to your account.
    </p>
</div>
<div class=""row"">
    <div class=""col-md-12"">
");
            EndContext();
#line 20 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
         for (var row = 0; row < Model.RecoveryCodes.Length; row += 2)
        {

#line default
#line hidden
            BeginContext(599, 40, true);
            WriteLiteral("            <code class=\"recovery-code\">");
            EndContext();
            BeginContext(640, 24, false);
#line 22 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
                                   Write(Model.RecoveryCodes[row]);

#line default
#line hidden
            EndContext();
            BeginContext(664, 7, true);
            WriteLiteral("</code>");
            EndContext();
            BeginContext(677, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(690, 28, true);
            WriteLiteral("<code class=\"recovery-code\">");
            EndContext();
            BeginContext(719, 28, false);
#line 22 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
                                                                                                                  Write(Model.RecoveryCodes[row + 1]);

#line default
#line hidden
            EndContext();
            BeginContext(747, 14, true);
            WriteLiteral("</code><br />\n");
            EndContext();
#line 23 "C:\Users\daxra\Desktop\WAD Project\HomeWork\Homework\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
        }

#line default
#line hidden
            BeginContext(771, 17, true);
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShowRecoveryCodesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShowRecoveryCodesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShowRecoveryCodesModel>)PageContext?.ViewData;
        public ShowRecoveryCodesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
