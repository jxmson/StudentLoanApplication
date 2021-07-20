#pragma checksum "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\Apply\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f57cc43d90872fcb8594dc873e55bb63e9310c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Apply_List), @"mvc.1.0.view", @"/Views/Apply/List.cshtml")]
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
#line 1 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\_ViewImports.cshtml"
using StudentLoan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\_ViewImports.cshtml"
using StudentLoan.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\_ViewImports.cshtml"
using StudentLoan.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\_ViewImports.cshtml"
using StudentLoan.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\_ViewImports.cshtml"
using StudentLoan.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f57cc43d90872fcb8594dc873e55bb63e9310c1", @"/Views/Apply/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3af1ce2d2647d925b3728e4da286f868531755f", @"/Views/_ViewImports.cshtml")]
    public class Views_Apply_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Application>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("listlink"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none; color:gray;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApplicationDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\Apply\List.cshtml"
   
    ViewData["Title"] = "List of Applications";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Summary of Applications</h2>\r\n\r\n<p>This is a summary of all the applications that are currently active. To see each applications full details, click on the applicants name.</p>\r\n\r\n<div id=\"List\">\r\n");
#nullable restore
#line 10 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\Apply\List.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered"">
        <tr>
            <th>Applicant First Name</th>
            <th>Applicant Surname</th>
            <th>Institution</th>
            <th>Course</th>
            <th>Date of Study</th>
            <th>Intended Date of Completion</th>
        </tr>
");
#nullable restore
#line 21 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\Apply\List.cshtml"
         foreach(Application a in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f57cc43d90872fcb8594dc873e55bb63e9310c17010", async() => {
#nullable restore
#line 24 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\Apply\List.cshtml"
                                                                                                                                          Write(a.FirstName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\Apply\List.cshtml"
                                                                                                                 WriteLiteral(a.ApplicationId);

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
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\Apply\List.cshtml"
               Write(a.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\Apply\List.cshtml"
               Write(a.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\Apply\List.cshtml"
               Write(a.Course);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\Apply\List.cshtml"
               Write(a.DateofAdmission);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\Apply\List.cshtml"
               Write(a.DateOfCompletion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\Apply\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 33 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\Apply\List.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>There are currently no active applications.</p>\r\n");
#nullable restore
#line 37 "C:\Users\Nthabeleng Jimson\Desktop\Ongoing coding projects\StudentLoan - RepositoryPattern implementation\Views\Apply\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f57cc43d90872fcb8594dc873e55bb63e9310c112180", async() => {
                WriteLiteral("Back to Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Application>> Html { get; private set; }
    }
}
#pragma warning restore 1591