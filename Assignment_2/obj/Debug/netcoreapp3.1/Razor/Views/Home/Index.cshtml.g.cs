#pragma checksum "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a08fb2e902170dcfc744beae66851cce3d7f894"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\_ViewImports.cshtml"
using Assignment_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\_ViewImports.cshtml"
using Assignment_2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a08fb2e902170dcfc744beae66851cce3d7f894", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eba48026f3206873ad263ac9c727ea8ad18f17cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Assignment_2.Viewmodel.ScheduleViewmodel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 6 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Schedules";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 12 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{
    if (this.User.IsInRole("Admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>All Enrolled Schedules</h1>\r\n");
#nullable restore
#line 17 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>My Enrolled Schedules</h1>\r\n");
#nullable restore
#line 21 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n\r\n                    ");
#nullable restore
#line 28 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </th>\r\n");
#nullable restore
#line 31 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                 if (this.User.IsInRole("Coach"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>\r\n\r\n                        ");
#nullable restore
#line 35 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Member));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </th>\r\n");
#nullable restore
#line 38 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                }
                else if (this.User.IsInRole("Member"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>\r\n\r\n                        ");
#nullable restore
#line 43 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Coach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </th>\r\n");
#nullable restore
#line 46 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>\r\n\r\n                        ");
#nullable restore
#line 51 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Coach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </th>\r\n                    <th>\r\n\r\n                        ");
#nullable restore
#line 56 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Member));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </th>\r\n");
#nullable restore
#line 59 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>\r\n\r\n                    ");
#nullable restore
#line 62 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </th>\r\n\r\n                <th>\r\n\r\n                    ");
#nullable restore
#line 68 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </th>\r\n\r\n                <th>\r\n\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 78 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {
                if (this.User.IsInRole("Coach"))
                {
                    if (item.Coach == User.Identity.Name)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 86 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                           Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 89 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                           Write(item.Member);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 92 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                           Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 95 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                           Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 99 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                    }
                }

                else if (this.User.IsInRole("Member"))
                {
                    if (item.Member == User.Identity.Name)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 108 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                           Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 111 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                           Write(item.CoachName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 114 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                           Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 117 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                           Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a08fb2e902170dcfc744beae66851cce3d7f89412351", async() => {
                WriteLiteral("Unenrol");
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
#nullable restore
#line 120 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                                                         WriteLiteral(item.Member);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 124 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                    }
                }
                else
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 131 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                       Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 134 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                       Write(item.CoachName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 137 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                       Write(item.Member);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 140 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                       Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 143 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
                       Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 147 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"


                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n");
#nullable restore
#line 154 "D:\Desktop\HIT339\ECorpSales\HIT339_Assignment2Group\Assignment_2\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public RoleManager<IdentityRole> Rolemanager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Assignment_2.Viewmodel.ScheduleViewmodel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
