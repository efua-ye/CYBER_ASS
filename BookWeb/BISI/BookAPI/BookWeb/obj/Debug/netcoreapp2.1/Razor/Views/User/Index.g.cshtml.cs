#pragma checksum "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9ef0d97f687bda5f6e67723c94aac7a4f445bcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
#line 1 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\_ViewImports.cshtml"
using BookWeb;

#line default
#line hidden
#line 2 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\_ViewImports.cshtml"
using BookWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9ef0d97f687bda5f6e67723c94aac7a4f445bcd", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc3f36e1caa5a8ac057f73f4a95ef59fb577cb5e", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookWeb.Entities.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn float-right hidden-sm-down btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
            BeginContext(80, 44, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html dir=\"ltr\" lang=\"en\">\n");
            EndContext();
            BeginContext(124, 988, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d53b67b6d6934bb48507bf6aa2d9a57d", async() => {
                BeginContext(130, 975, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <!-- Tell the browser to be responsive to screen width -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">
    <!-- Favicon icon -->
    <link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""../../assets/images/favicon.png"">
    <title>Xtreme Admin Template - The Ultimate Multipurpose admin template</title>
    <!-- Custom CSS -->
    <link href=""../../dist/css/style.min.css"" rel=""stylesheet"">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src=""https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js""></script>
        <script src=""https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js""></script>
    <![endif]-->
");
                EndContext();
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
            EndContext();
            BeginContext(1112, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1113, 8267, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecc94cd701f04ba6987ef78b9be86e97", async() => {
                BeginContext(1119, 1775, true);
                WriteLiteral(@"
    <!-- ============================================================== -->
    <!-- Preloader - style you can find in spinners.css -->
    <!-- ============================================================== -->
    <div class=""preloader"">
        <div class=""lds-ripple"">
            <div class=""lds-pos""></div>
            <div class=""lds-pos""></div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- Main wrapper - style you can find in pages.scss -->
    <!-- ============================================================== -->
    <div id=""main-wrapper"" data-layout=""vertical"" data-navbarbg=""skin5"" data-sidebartype=""full"" data-sidebar-position=""absolute"" data-header-position=""absolute"" data-boxed-layout=""full"">
        <div class=""page-wrapper"">
            <!-- ============================================================== -->
            <!-- Bread crumb and right sidebar toggle -->
            <!-- ==================================================");
                WriteLiteral(@"============ -->
            <div class=""page-breadcrumb"">
                <div class=""row align-items-center"">
                    <div class=""col-5"">
                        <h4 class=""page-title"">Users</h4>
                        <div class=""d-flex align-items-center"">
                            <nav aria-label=""breadcrumb"">
                                <ol class=""breadcrumb"">
                                    <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                                    <li class=""breadcrumb-item active"" aria-current=""page"">Users</li>
                                </ol>
                            </nav>
                        </div>
                    </div>
                    <div class=""col-7"">
");
                EndContext();
                BeginContext(3150, 1259, true);
                WriteLiteral(@"                    </div>
                </div>
            </div>
            <!-- ============================================================== -->
            <!-- End Bread crumb and right sidebar toggle -->
            <!-- ============================================================== -->
            <!-- ============================================================== -->
            <!-- Container fluid  -->
            <!-- ============================================================== -->
            <div class=""container-fluid"">
                <!-- ============================================================== -->
                <!-- Start Page Content -->
                <!-- ============================================================== -->
                <div class=""row"">

                    <div class=""col-12"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <h4 class=""card-title"">User Details</h4>
             ");
                WriteLiteral("                   <h6 class=\"card-subtitle\">Our faithful followers and contributors.</h6>\n                            </div>\n                            <div class=\"col-md-12 col-12 align-self-center\">\n                                ");
                EndContext();
                BeginContext(4409, 146, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5f0074bfc124f02b9850afda4bc10a6", async() => {
                    BeginContext(4505, 46, true);
                    WriteLiteral("<i class=\"mdi mdi-account-plus\"></i>  New User");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4555, 943, true);
                WriteLiteral(@"
                            </div>
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <thead class=""thead-light"">
                                        <tr>
                                            <th scope=""col"">Id</th>
                                            <th scope=""col"">First Name</th>
                                            <th scope=""col"">Last Name</th>
                                            <th scope=""col"">Username</th>
                                            <th scope=""col"">Email</th>
                                            <th scope=""col"">Phone Number</th>
                                            <th></th>
                                            <th></th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
                EndContext();
#line 101 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\User\Index.cshtml"
                                         foreach (var user in Model)
                                        {

#line default
#line hidden
                BeginContext(5609, 101, true);
                WriteLiteral("                                            <tr>\n                                                <td>");
                EndContext();
                BeginContext(5711, 7, false);
#line 104 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\User\Index.cshtml"
                                               Write(user.Id);

#line default
#line hidden
                EndContext();
                BeginContext(5718, 58, true);
                WriteLiteral("</td>\n                                                <td>");
                EndContext();
                BeginContext(5777, 14, false);
#line 105 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\User\Index.cshtml"
                                               Write(user.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(5791, 58, true);
                WriteLiteral("</td>\n                                                <td>");
                EndContext();
                BeginContext(5850, 13, false);
#line 106 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\User\Index.cshtml"
                                               Write(user.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(5863, 58, true);
                WriteLiteral("</td>\n                                                <td>");
                EndContext();
                BeginContext(5922, 13, false);
#line 107 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\User\Index.cshtml"
                                               Write(user.Username);

#line default
#line hidden
                EndContext();
                BeginContext(5935, 58, true);
                WriteLiteral("</td>\n                                                <td>");
                EndContext();
                BeginContext(5994, 10, false);
#line 108 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\User\Index.cshtml"
                                               Write(user.Email);

#line default
#line hidden
                EndContext();
                BeginContext(6004, 58, true);
                WriteLiteral("</td>\n                                                <td>");
                EndContext();
                BeginContext(6063, 12, false);
#line 109 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\User\Index.cshtml"
                                               Write(user.PhoneNo);

#line default
#line hidden
                EndContext();
                BeginContext(6075, 58, true);
                WriteLiteral("</td>\n                                                <td>");
                EndContext();
                BeginContext(6133, 104, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de8a524ae3eb41ad98e2decbbe4b062d", async() => {
                    BeginContext(6189, 44, true);
                    WriteLiteral("<i class=\"ti-pencil\" aria-hidden=\"true\"></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 110 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\User\Index.cshtml"
                                                                           WriteLiteral(user.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6237, 59, true);
                WriteLiteral(" </td>\n                                                <td>");
                EndContext();
                BeginContext(6296, 107, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00d1ca772ce74547b1f5f1d8a7aaa7a6", async() => {
                    BeginContext(6356, 43, true);
                    WriteLiteral("<i class=\"ti-trash\" aria-hidden=\"true\"></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 111 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\User\Index.cshtml"
                                                                             WriteLiteral(user.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6403, 57, true);
                WriteLiteral(" </td>\n                                            </tr>\n");
                EndContext();
#line 113 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\User\Index.cshtml"
                                        }

#line default
#line hidden
                BeginContext(6502, 2871, true);
                WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- ============================================================== -->
                <!-- End PAge Content -->
                <!-- ============================================================== -->
                <!-- ============================================================== -->
                <!-- Right sidebar -->
                <!-- ============================================================== -->
                <!-- .right-sidebar -->
                <!-- ============================================================== -->
                <!-- End Right sidebar -->
                <!-- ============================================================== -->
            </div>
            <!-- ============================================================== -->
            <!-- End Contai");
                WriteLiteral(@"ner fluid  -->
            <!-- ============================================================== -->
            <!-- ============================================================== -->
            <!-- footer -->
            <!-- ============================================================== -->
            <footer class=""footer text-center"">
                All Rights Reserved by Xtreme Admin. Designed and Developed by <a href=""https://wrappixel.com"">WrapPixel</a>.
            </footer>
            <!-- ============================================================== -->
            <!-- End footer -->
            <!-- ============================================================== -->
        </div>
        <!-- ============================================================== -->
        <!-- End Page wrapper  -->
        <!-- ============================================================== -->
    </div>
    <!-- ============================================================== -->
    <!-- End Wrapper -->
    <!-- ==");
                WriteLiteral(@"============================================================ -->
    <!-- ============================================================== -->
    <!-- All Jquery -->
    <!-- ============================================================== -->
    <script src=""../../assets/libs/jquery/dist/jquery.min.js""></script>
    <!-- Bootstrap tether Core JavaScript -->
    <script src=""../../assets/libs/popper.js/dist/umd/popper.min.js""></script>
    <script src=""../../assets/libs/bootstrap/dist/js/bootstrap.min.js""></script>
    <script src=""../../dist/js/app-style-switcher.js""></script>
    <!--Wave Effects -->
    <script src=""../../dist/js/waves.js""></script>
    <!--Menu sidebar -->
    <script src=""../../dist/js/sidebarmenu.js""></script>
    <!--Custom JavaScript -->
    <script src=""../../dist/js/custom.js""></script>
");
                EndContext();
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
            EndContext();
            BeginContext(9380, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookWeb.Entities.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
