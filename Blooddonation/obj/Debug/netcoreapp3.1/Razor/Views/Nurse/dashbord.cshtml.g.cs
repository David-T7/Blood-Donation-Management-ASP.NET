#pragma checksum "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6abf5edab467511cf90b82d9e8494a150b5eeb7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nurse_dashbord), @"mvc.1.0.view", @"/Views/Nurse/dashbord.cshtml")]
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
#line 1 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\_ViewImports.cshtml"
using Blooddonation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\_ViewImports.cshtml"
using Blooddonation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6abf5edab467511cf90b82d9e8494a150b5eeb7a", @"/Views/Nurse/dashbord.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e771b9cd45c68150793946ee098399759e1c40", @"/Views/_ViewImports.cshtml")]
    public class Views_Nurse_dashbord : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
  
    ViewData["Title"] = "dashbord";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6abf5edab467511cf90b82d9e8494a150b5eeb7a3598", async() => {
                WriteLiteral("\r\n\r\n    <link href=\"css/sidebar.css\" rel=\"stylesheet\">\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6abf5edab467511cf90b82d9e8494a150b5eeb7a4634", async() => {
                WriteLiteral(@"
    <div class=""side-navbar active-nav d-flex justify-content-between flex-wrap flex-column""
         id=""sidebar"">

        <ul class=""nav flex-column text-white w-100"">
            <a href=""#"" class=""nav-link h3 text-white my-2"">
                Donor
            </a>
            <li class=""nav-link"">
                <i class=""bx bxs-dashboard""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""#""> Home</a></span>
            </li>

            <li class=""nav-link"">
                <i class=""bx bx-git-pull-request""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""#"">Appointment</a></span>
            </li>



            <li class=""nav-link"">
                <i class=""bx bx-git-pull-request""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""#""> Request</a></span>
            </li>



            <li class=""nav-link"">
                <i class=""bx bx-edit""></i>
                <span class=""mx-2""><a class=""inner-anchor"" h");
                WriteLiteral(@"ref=""#editaccount""> Edit Account</a></span>
            </li>

            <li class=""nav-link"">
                <i class=""bx bx-log-out""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""#""> Log Out </a></span>
            </li>
        </ul>

    </div>




    <!-- Main Wrapper -->
    <div class=""p-1 my-container active-cont"" style=""background-color:lightblue"">
        <!-- Top Nav -->
        <nav class=""navbar top-navbar navbar-light bg-light px-5"">
            <a class=""btn border-0"" id=""menu-btn""><i class=""bx bx-menu""></i></a>
        </nav>


        <br>
        <div class=""container"">
            <div class=""row"" style=""column-gap: 70px;"">
                <div class=""card"" style=""width: 10rem;"">

                    <div class=""card-body"">
                        <p class=""card-text""><b> 0 </b> <br>Request</p>
                    </div>
                </div>
                <div class=""card"" style=""width: 10rem;"">

                    <div class");
                WriteLiteral(@"=""card-body"">
                        <p class=""card-text""><b> 0 </b> <br>Accepted</p>
                    </div>
                </div>

                <div class=""card"" style=""width: 10rem;"">

                    <div class=""card-body"">
                        <p class=""card-text""><b> 0 </b> <br>Pending</p>
                    </div>
                </div>

                <div class=""card"" style=""width: 10rem;"">

                    <div class=""card-body"">
                        <p class=""card-text""><b> 0 </b> <br>Rejected</p>
                    </div>
                </div>

            </div>

            <br>
        </div>

        <table>

            <thead>
                <tr>
                    <th>Date</th>
                    <th>Time</th>
                    <th>Status</th>
                    <th>Appointment</th>
                </tr>


            </thead>
            <tbody>
                <tr>
                    <td> now </td>
                   ");
                WriteLiteral(@" <td> now  </td>
                    <td>
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" style=""background-color: yellow;"" class=""bi bi-circle"" viewBox=""0 0 16 16"">
                            <path d=""M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
                        </svg>


                        &nbsp;accepted
                    </td>

                    <td><button type=""button""");
                BeginWriteAttribute("href", " href=\"", 3734, "\"", 3741, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary btn-sm\" style=\"background-color: red;\">Make Appointment</button></td>\r\n\r\n\r\n\r\n\r\n            </tbody>\r\n        </table>\r\n\r\n\r\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
