#pragma checksum "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\dashbord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3d31215e2fe56704769df61efb75e612f508d0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Donor_dashbord), @"mvc.1.0.view", @"/Views/Donor/dashbord.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3d31215e2fe56704769df61efb75e612f508d0b", @"/Views/Donor/dashbord.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e771b9cd45c68150793946ee098399759e1c40", @"/Views/_ViewImports.cshtml")]
    public class Views_Donor_dashbord : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 2 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\dashbord.cshtml"
   ViewData["Title"] = "dashbord"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d31215e2fe56704769df61efb75e612f508d0b3551", async() => {
                WriteLiteral("\r\n\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d31215e2fe56704769df61efb75e612f508d0b4529", async() => {
                WriteLiteral(@"
    <div class=""side-navbar active-nav d-flex justify-content-between flex-wrap flex-column""
         id=""sidebar"">

        <ul class=""nav flex-column text-white w-100"">
            <a href=""/donor/dashbord"" class=""nav-link h3 text-white my-2"">
                Donor
            </a>
            <li class=""nav-link"">
                <i class=""bx bxs-dashboard""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/donor/dashbord""> Home</a></span>
            </li>

            <li class=""nav-link"">
                <i class=""bx bx-git-pull-request""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/donor/appointmentlist"">Appointment</a></span>
            </li>



            <li class=""nav-link"">
                <i class=""bx bx-git-pull-request""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/donor/donationrequestlist""> Request</a></span>
            </li>



            <li class=""nav-link"">
                <i class=""bx b");
                WriteLiteral(@"x-edit""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/donor/editaccount""> Edit Account</a></span>
            </li>

            <li class=""nav-link"">
                <i class=""bx bx-log-out""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/donor/logout""> Log Out </a></span>
            </li>
        </ul>

    </div>




    <!-- Main Wrapper -->
    <div class=""p-1 my-container active-cont"" style=""background-color:lightblue"">
        <!-- Top Nav -->
        <nav class=""navbar top-navbar navbar-light bg-light px-5"">
            <br />
        </nav>
        <br><br>


        <table class=""styled-table"">

            <thead>
                <tr>
                    <th>Date</th>
                    <th>Status</th>
                    <th>Appointment</th>
                </tr>


            </thead>

            <tbody>


");
#nullable restore
#line 80 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\dashbord.cshtml"
                 foreach (var request in Model.donationrequest)
                {

                    int match = 0;

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td> ");
#nullable restore
#line 85 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\dashbord.cshtml"
                        Write(request.RequestDate);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 86 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\dashbord.cshtml"
                        Write(request.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("  </td>\r\n\r\n");
#nullable restore
#line 88 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\dashbord.cshtml"
                         foreach (var appointment in Model.appointmentlist)
                        {

                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\dashbord.cshtml"
                             if (request.Status == "accepted" && request.ReqeustResultId == appointment.ReqeustResultId)
                            {
                                match += 1;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>  ");
#nullable restore
#line 94 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\dashbord.cshtml"
                                 Write(appointment.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n");
#nullable restore
#line 95 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\dashbord.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\dashbord.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\dashbord.cshtml"
                         if (match == 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td>Not made</td>\r\n");
#nullable restore
#line 101 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\dashbord.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 103 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\dashbord.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 105 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\dashbord.cshtml"
                 if (Model == null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>No</td>\r\n                        <td>Donation</td>\r\n                        <td>Request</td>\r\n                        <td></td>\r\n                    </tr>\r\n");
#nullable restore
#line 113 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\dashbord.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </table>\r\n\r\n        <br><br>\r\n        <br><br>\r\n        <br><br>\r\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
