#pragma checksum "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49c671e2e07159f48822743e83feeda80157c076"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Index.cshtml", typeof(AspNetCore.Views_Book_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49c671e2e07159f48822743e83feeda80157c076", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc3f36e1caa5a8ac057f73f4a95ef59fb577cb5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookWeb.Entities.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn float-right hidden-sm-down btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml"
   
    ViewData["Title"] = "Books";

#line default
#line hidden
            BeginContext(81, 44, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html dir=\"ltr\" lang=\"en\">\n");
            EndContext();
            BeginContext(125, 973, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "327f5f30a5684fcdac70a4e8a616eb47", async() => {
                BeginContext(131, 960, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <!-- Tell the browser to be responsive to screen width -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""description"" content="""">
    <meta name=""book"" content="""">
    <!-- Favicon icon -->
    <link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""../../assets/images/favicon.png"">
    <title>Booktastic - Probably the best book store out there</title>
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
            BeginContext(1098, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1099, 8056, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "897a7ac6bc864b3c82360f870363347d", async() => {
                BeginContext(1105, 1775, true);
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
                        <h4 class=""page-title"">Books</h4>
                        <div class=""d-flex align-items-center"">
                            <nav aria-label=""breadcrumb"">
                                <ol class=""breadcrumb"">
                                    <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                                    <li class=""breadcrumb-item active"" aria-current=""page"">Books</li>
                                </ol>
                            </nav>
                        </div>
                    </div>
                    <div class=""col-7"">
");
                EndContext();
                BeginContext(3136, 1256, true);
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
                                <h4 class=""card-title"">Book Details</h4>
             ");
                WriteLiteral("                   <h6 class=\"card-subtitle\">The ultimate all-you-can-read buffet.</h6>\n                            </div>\n                            <div class=\"col-md-12 col-12 align-self-center\">\n                                ");
                EndContext();
                BeginContext(4392, 143, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d10c2d273814b928406393201c398db", async() => {
                    BeginContext(4488, 43, true);
                    WriteLiteral("<i class=\"mdi mdi-plus-circle\"></i>New Book");
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
                BeginContext(4535, 1238, true);
                WriteLiteral(@"
                            </div>
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <thead class=""thead-light"">
                                        <tr>
                                            <th scope=""col"">Id</th>
                                            <th scope=""col"">Title</th>
                                            <th scope=""col"">Author ID</th>
                                            <th scope=""col"">Genre ID</th>
                                            <th scope=""col"">ISBN</th>
                                            <th scope=""col"">Year Published</th>
                                            <th scope=""col"">Rating</th>
                                            <th scope=""col"">Summary</th>
                                            <th scope=""col"">Created By</th>
                                            <th scope=""col"">Date Created</th>
                             ");
                WriteLiteral("               <th></th>\n                                            <th></th>\n                                        </tr>\n                                    </thead>\n                                    <tbody>\n");
                EndContext();
#line 105 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                         foreach (var book in Model)
                                        {

#line default
#line hidden
                BeginContext(5884, 93, true);
                WriteLiteral("                                        <tr>\n                                            <td>");
                EndContext();
                BeginContext(5978, 7, false);
#line 108 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.Id);

#line default
#line hidden
                EndContext();
                BeginContext(5985, 54, true);
                WriteLiteral("</td>\n                                            <td>");
                EndContext();
                BeginContext(6040, 10, false);
#line 109 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.Title);

#line default
#line hidden
                EndContext();
                BeginContext(6050, 54, true);
                WriteLiteral("</td>\n                                            <td>");
                EndContext();
                BeginContext(6105, 13, false);
#line 110 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.AuthorId);

#line default
#line hidden
                EndContext();
                BeginContext(6118, 54, true);
                WriteLiteral("</td>\n                                            <td>");
                EndContext();
                BeginContext(6173, 12, false);
#line 111 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.GenreID);

#line default
#line hidden
                EndContext();
                BeginContext(6185, 54, true);
                WriteLiteral("</td>\n                                            <td>");
                EndContext();
                BeginContext(6240, 9, false);
#line 112 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.ISBN);

#line default
#line hidden
                EndContext();
                BeginContext(6249, 54, true);
                WriteLiteral("</td>\n                                            <td>");
                EndContext();
                BeginContext(6304, 16, false);
#line 113 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.YearPublish);

#line default
#line hidden
                EndContext();
                BeginContext(6320, 54, true);
                WriteLiteral("</td>\n                                            <td>");
                EndContext();
                BeginContext(6375, 11, false);
#line 114 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.Rating);

#line default
#line hidden
                EndContext();
                BeginContext(6386, 54, true);
                WriteLiteral("</td>\n                                            <td>");
                EndContext();
                BeginContext(6441, 12, false);
#line 115 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.Summary);

#line default
#line hidden
                EndContext();
                BeginContext(6453, 54, true);
                WriteLiteral("</td>\n                                            <td>");
                EndContext();
                BeginContext(6508, 14, false);
#line 116 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.CreatedBy);

#line default
#line hidden
                EndContext();
                BeginContext(6522, 54, true);
                WriteLiteral("</td>\n                                            <td>");
                EndContext();
                BeginContext(6577, 16, false);
#line 117 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.DateCreated);

#line default
#line hidden
                EndContext();
                BeginContext(6593, 54, true);
                WriteLiteral("</td>\n                                            <td>");
                EndContext();
                BeginContext(6647, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66efa341bccf49189afa252b44598736", async() => {
                    BeginContext(6692, 44, true);
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
#line 118 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                                                       WriteLiteral(book.Id);

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
                BeginContext(6740, 55, true);
                WriteLiteral(" </td>\n                                            <td>");
                EndContext();
                BeginContext(6795, 189, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e0e9b86704f4b34a4374f760eea8e64", async() => {
                    BeginContext(6855, 38, true);
                    WriteLiteral("<i class=\"ti-trash\" aria-hidden=\"true\"");
                    EndContext();
                    BeginWriteAttribute("onclick", " onclick=\"", 6893, "\"", 6974, 12);
                    WriteAttributeValue("", 6903, "return", 6903, 6, true);
                    WriteAttributeValue(" ", 6909, "confirm(\'Are", 6910, 13, true);
                    WriteAttributeValue(" ", 6922, "you", 6923, 4, true);
                    WriteAttributeValue(" ", 6926, "sure", 6927, 5, true);
                    WriteAttributeValue(" ", 6931, "you", 6932, 4, true);
                    WriteAttributeValue(" ", 6935, "want", 6936, 5, true);
                    WriteAttributeValue(" ", 6940, "to", 6941, 3, true);
                    WriteAttributeValue(" ", 6943, "delete", 6944, 7, true);
                    WriteAttributeValue(" ", 6950, "the", 6951, 4, true);
                    WriteAttributeValue(" ", 6954, "book", 6955, 5, true);
#line 119 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml"
WriteAttributeValue(" ", 6959, book.Title, 6960, 11, false);

#line default
#line hidden
                    WriteAttributeValue("", 6971, "?\')", 6971, 3, true);
                    EndWriteAttribute();
                    BeginContext(6975, 5, true);
                    WriteLiteral("></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 119 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                                                         WriteLiteral(book.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6984, 53, true);
                WriteLiteral(" </td>\n                                        </tr>\n");
                EndContext();
#line 121 "C:\Users\GODWIN\Downloads\CYB\BookAPIAuthentication-master\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                        }

#line default
#line hidden
                BeginContext(7079, 2069, true);
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
        </div>
        <!-- ============================================================== -->
        <!-- End");
                WriteLiteral(@" Page wrapper  -->
        <!-- ============================================================== -->
    </div>
    <!-- ============================================================== -->
    <!-- End Wrapper -->
    <!-- ============================================================== -->
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
    <script src=""../../dist/js/");
                WriteLiteral("custom.js\"></script>\n");
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
            BeginContext(9155, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookWeb.Entities.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
