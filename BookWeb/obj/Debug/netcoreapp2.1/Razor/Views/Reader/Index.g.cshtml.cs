#pragma checksum "C:\Users\GODWIN\Downloads\CYB\EFUA_BookAPI\TheBookWeb\Views\Reader\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02e3379cb217dd3b6e4cde04f6107424c5d6c74d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reader_Index), @"mvc.1.0.view", @"/Views/Reader/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reader/Index.cshtml", typeof(AspNetCore.Views_Reader_Index))]
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
#line 1 "C:\Users\GODWIN\Downloads\CYB\EFUA_BookAPI\TheBookWeb\Views\_ViewImports.cshtml"
using BookWeb;

#line default
#line hidden
#line 2 "C:\Users\GODWIN\Downloads\CYB\EFUA_BookAPI\TheBookWeb\Views\_ViewImports.cshtml"
using BookWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02e3379cb217dd3b6e4cde04f6107424c5d6c74d", @"/Views/Reader/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba6b1b965d54a65f696aeef7f37afda1d7ae018", @"/Views/_ViewImports.cshtml")]
    public class Views_Reader_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookWeb.Entities.Reader>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reader", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn float-right hidden-sm-down btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to delete this record\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\GODWIN\Downloads\CYB\EFUA_BookAPI\TheBookWeb\Views\Reader\Index.cshtml"
  
    ViewData["Title"] = "Reader";

#line default
#line hidden
            BeginContext(87, 155, true);
            WriteLiteral("<div id=\"page-wrapper\">\r\n    <div class=\"main-page\">\r\n        <div class=\"tables\">\r\n           \r\n                    <h4>READER:</h4>\r\n                    ");
            EndContext();
            BeginContext(242, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f764818f75746d6b4ef6f6d1be559bd", async() => {
                BeginContext(340, 45, true);
                WriteLiteral("<i class=\"mdi mdi-plus-circle\"></i>New Reader");
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
            BeginContext(389, 743, true);
            WriteLiteral(@"

                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class=""table table-bordered"" id=""dataTable"" cellspacing=""0"">
                                <thead>
                                    <tr>
                                        <th>ID</th>
                                        <th>Name</th>
                                        <th>Favourite Book</th>
                                        <th>FavouriteAuthor</th>
                                        <th>FavouritePublisher</th>
                                        <th>FavouriteGenre</th>
                                    </tr>
                                </thead>
");
            EndContext();
            BeginContext(1640, 41, true);
            WriteLiteral("                                <tbody>\r\n");
            EndContext();
#line 42 "C:\Users\GODWIN\Downloads\CYB\EFUA_BookAPI\TheBookWeb\Views\Reader\Index.cshtml"
                                     foreach (var reader in Model)
                                    {

#line default
#line hidden
            BeginContext(2204, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(2299, 9, false);
#line 45 "C:\Users\GODWIN\Downloads\CYB\EFUA_BookAPI\TheBookWeb\Views\Reader\Index.cshtml"
                                           Write(reader.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2308, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2364, 11, false);
#line 46 "C:\Users\GODWIN\Downloads\CYB\EFUA_BookAPI\TheBookWeb\Views\Reader\Index.cshtml"
                                           Write(reader.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2375, 56, true);
            WriteLiteral(" </td>\r\n                                            <td>");
            EndContext();
            BeginContext(2432, 20, false);
#line 47 "C:\Users\GODWIN\Downloads\CYB\EFUA_BookAPI\TheBookWeb\Views\Reader\Index.cshtml"
                                           Write(reader.FavouriteBook);

#line default
#line hidden
            EndContext();
            BeginContext(2452, 57, true);
            WriteLiteral("  </td>\r\n                                            <td>");
            EndContext();
            BeginContext(2510, 22, false);
#line 48 "C:\Users\GODWIN\Downloads\CYB\EFUA_BookAPI\TheBookWeb\Views\Reader\Index.cshtml"
                                           Write(reader.FavouriteAuthor);

#line default
#line hidden
            EndContext();
            BeginContext(2532, 57, true);
            WriteLiteral("  </td>\r\n                                            <td>");
            EndContext();
            BeginContext(2590, 25, false);
#line 49 "C:\Users\GODWIN\Downloads\CYB\EFUA_BookAPI\TheBookWeb\Views\Reader\Index.cshtml"
                                           Write(reader.FavouritePublisher);

#line default
#line hidden
            EndContext();
            BeginContext(2615, 57, true);
            WriteLiteral("  </td>\r\n                                            <td>");
            EndContext();
            BeginContext(2673, 21, false);
#line 50 "C:\Users\GODWIN\Downloads\CYB\EFUA_BookAPI\TheBookWeb\Views\Reader\Index.cshtml"
                                           Write(reader.FavouriteGenre);

#line default
#line hidden
            EndContext();
            BeginContext(2694, 59, true);
            WriteLiteral("    </td>\r\n                                            <td>");
            EndContext();
            BeginContext(2753, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82ea6438dc5947f08f5caed37e23b5e9", async() => {
                BeginContext(2811, 54, true);
                WriteLiteral("<i class=\"fa fa-pencil m-r-10\" aria-hidden=\"true\"></i>");
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
#line 51 "C:\Users\GODWIN\Downloads\CYB\EFUA_BookAPI\TheBookWeb\Views\Reader\Index.cshtml"
                                                                       WriteLiteral(reader.Id);

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
            BeginContext(2869, 56, true);
            WriteLiteral(" </td>\r\n                                            <td>");
            EndContext();
            BeginContext(2925, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eed319055743447aa8b264116b17decf", async() => {
                BeginContext(3049, 55, true);
                WriteLiteral("<i class=\"fa fa-trash-o m-r-10\" aria-hidden=\"true\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\GODWIN\Downloads\CYB\EFUA_BookAPI\TheBookWeb\Views\Reader\Index.cshtml"
                                                                                                                                                    WriteLiteral(reader.Id);

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
            BeginContext(3108, 55, true);
            WriteLiteral(" </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 54 "C:\Users\GODWIN\Downloads\CYB\EFUA_BookAPI\TheBookWeb\Views\Reader\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3202, 849, true);
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>

            </div>
            <!-- /.container-fluid -->
        </div>


<!-- /.container-fluid -->
<script>
    var menuLeft = document.getElementById('cbp-spmenu-s1'),
        showLeftPush = document.getElementById('showLeftPush'),
        body = document.body;

    showLeftPush.onclick = function () {
        classie.toggle(this, 'active');
        classie.toggle(body, 'cbp-spmenu-push-toright');
        classie.toggle(menuLeft, 'cbp-spmenu-open');
        disableOther('showLeftPush');
    };

    function disableOther(button) {
        if (button !== 'showLeftPush') {
            classie.toggle(showLeftPush, 'disabled');
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookWeb.Entities.Reader>> Html { get; private set; }
    }
}
#pragma warning restore 1591
