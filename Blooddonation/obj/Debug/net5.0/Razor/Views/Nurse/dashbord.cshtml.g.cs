#pragma checksum "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff6066e0588a09e3de9339943daf8d0ebf47c9a8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff6066e0588a09e3de9339943daf8d0ebf47c9a8", @"/Views/Nurse/dashbord.cshtml")]
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
#line 3 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
  
    ViewData["Title"] = "dashbord";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff6066e0588a09e3de9339943daf8d0ebf47c9a83598", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff6066e0588a09e3de9339943daf8d0ebf47c9a84634", async() => {
                WriteLiteral(@"
    <div class=""side-navbar active-nav d-flex justify-content-between flex-wrap flex-column""
         id=""sidebar"">

        <ul class=""nav flex-column text-white w-100"">
            <a href=""/nurse/dashbord"" class=""nav-link h3 text-white my-2"">
                Nurse
            </a>
            <li class=""nav-link"">
                <i class=""bx bxs-dashboard""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/nurse/dashbord""> Home</a></span>
            </li>

            <li class=""nav-link"">
                <i class=""bx bx-git-pull-request""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/nurse/donationrequest"">Request</a></span>
            </li>



            <li class=""nav-link"">
                <i class=""bx bx-git-pull-request""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/nurse/appointment""> Appointment </a></span>
            </li>



            <li class=""nav-link"">
                <i class=""bx bx-edit""");
                WriteLiteral(@"></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/nurse/editaccount""> Edit Account</a></span>
            </li>

            <li class=""nav-link"">
                <i class=""bx bx-log-out""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/nurse/logout""> Log Out </a></span>
            </li>
        </ul>

    </div>




    <!-- Main Wrapper -->

        <div class=""p-1 my-container active-cont"" style=""background-color:lightblue"">
            <!-- Top Nav -->
            <nav class=""navbar top-navbar navbar-light bg-light px-5"">
            <br />
            </nav>
            <br>
            <div class=""container"" style=""background-color:lightblue"">
                <div class=""row"" style=""column-gap: 70px;"">
                    <div class=""card"" style=""width: 10rem;"">

                        <div class=""card-body"">
                            <p class=""card-text""><b> ");
#nullable restore
#line 75 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                                                Write(Model.requestno);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </b> <br>Request</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card\" style=\"width: 10rem;\">\r\n\r\n                        <div class=\"card-body\">\r\n                            <p class=\"card-text\"><b> ");
#nullable restore
#line 81 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                                                Write(Model.acceptedrequest);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </b> <br>Accepted</p>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"card\" style=\"width: 10rem;\">\r\n\r\n                        <div class=\"card-body\">\r\n                            <p class=\"card-text\"><b> ");
#nullable restore
#line 88 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                                                Write(Model.inprogressrequest);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </b> <br>Pending</p>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"card\" style=\"width: 10rem;\">\r\n\r\n                        <div class=\"card-body\">\r\n                            <p class=\"card-text\"><b> ");
#nullable restore
#line 95 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                                                Write(Model.rejectedrequest);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </b> <br>Rejected</p>
                        </div>
                    </div>

                </div>

                <br>
            </div>
            <br />

            <table class=""styled-table"">

                <thead>
                    <tr>
                        <th>Date</th>
                        <th>Status</th>
                        <th>Appointment</th>
                        <th>DonorInfo</th>
                    </tr>


                </thead>

                <tbody>


");
#nullable restore
#line 121 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                     foreach (var request in Model.donationrequestlist)
                    {
                        int match = 0;



#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td> ");
#nullable restore
#line 127 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                            Write(request.RequestDate);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 128 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                            Write(request.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("  </td>\r\n");
#nullable restore
#line 129 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                             foreach (var appointment in Model.appointmentlist)
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                                 if (request.Status == "accepted" && request.ReqeustResultId == appointment.ReqeustResultId)
                                {
                                    match += 1;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>  ");
#nullable restore
#line 135 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                                     Write(appointment.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n");
#nullable restore
#line 136 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                                 

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                             if (match == 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>Not made</td>\r\n");
#nullable restore
#line 142 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <td> <a");
                BeginWriteAttribute("href", " href=\"", 4476, "\"", 4516, 2);
                WriteAttributeValue("", 4483, "/nurse/donorinfo/", 4483, 17, true);
#nullable restore
#line 144 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
WriteAttributeValue("", 4500, request.DonorId, 4500, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <button type=\"button\" class=\"btn btn-primary btn-sm\" style=\"background-color: red;\">DonorInfo</button></a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 146 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 148 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                     if (Model.donationrequestlist == null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>No</td>\r\n                            <td>Donation</td>\r\n                            <td>Request</td>\r\n                        </tr>\r\n");
#nullable restore
#line 155 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Nurse\dashbord.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </tbody>\r\n\r\n\r\n            </table>\r\n\r\n            <br /><br />\r\n            <br /><br />\r\n            <br /><br />\r\n\r\n\r\n        </div>\r\n\r\n");
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
