#pragma checksum "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Author\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78061a25b6f1022bfeffe363a5914fd2a2506605"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Index), @"mvc.1.0.view", @"/Views/Author/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Author/Index.cshtml", typeof(AspNetCore.Views_Author_Index))]
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
#line 1 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\_ViewImports.cshtml"
using MybookWeb;

#line default
#line hidden
#line 2 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\_ViewImports.cshtml"
using MybookWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78061a25b6f1022bfeffe363a5914fd2a2506605", @"/Views/Author/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff18cda3607c06ebc710d53d43315c6216d98a0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MybookWeb.Entities.Author>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Author", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn float-right hidden-sm-down btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ft-edit-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-hidden", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ft-delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Author\Index.cshtml"
  
    ViewData["Title"] = "Authors";

#line default
#line hidden
            BeginContext(90, 1058, true);
            WriteLiteral(@"
    <!-- fixed-top-->
    <nav class=""header-navbar navbar-expand-md navbar navbar-with-menu navbar-without-dd-arrow fixed-top navbar-semi-light"">
        <div class=""navbar-wrapper"">
            <div class=""navbar-container content"">
                <div class=""collapse navbar-collapse show"" id=""navbar-mobile"">
                    <ul class=""nav navbar-nav mr-auto float-left"">
                        <li class=""nav-item d-block d-md-none""><a class=""nav-link nav-menu-main menu-toggle hidden-xs"" href=""#""><i class=""ft-mic""></i></a></li>
                        <li class=""nav-item d-none d-md-block""><a class=""nav-link nav-link-expand"" href=""#""><i class=""ficon ft-maximize""></i></a></li>
                        <li class=""nav-item dropdown navbar-search"">
                            <a class=""nav-link dropdown-toggle hide"" data-toggle=""dropdown"" href=""#""><i class=""ficon ft-search""></i></a>
                            <ul class=""dropdown-menu"">
                                <li class=""arrow_box"">
  ");
            WriteLiteral("                                  ");
            EndContext();
            BeginContext(1148, 597, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bea2be8a28c4cbf9e966be7e7a2154e", async() => {
                BeginContext(1154, 584, true);
                WriteLiteral(@"
                                        <div class=""input-group search-box"">
                                            <div class=""position-relative has-icon-right full-width"">
                                                <input class=""form-control"" id=""search"" type=""text"" placeholder=""Search here..."">
                                                <div class=""form-control-position navbar-search-close""><i class=""ft-x"">   </i></div>
                                            </div>
                                        </div>
                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1745, 7599, true);
            WriteLiteral(@"
                                </li>
                            </ul>
                        </li>
                    </ul>
                    <ul class=""nav navbar-nav float-right"">
                        <li class=""dropdown dropdown-language nav-item"">
                            <a class=""dropdown-toggle nav-link"" id=""dropdown-flag"" href=""#"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><i class=""flag-icon flag-icon-ng""></i><span class=""selected-language""></span></a>
                            <div class=""dropdown-menu"" aria-labelledby=""dropdown-flag"">
                                <div class=""arrow_box""><a class=""dropdown-item"" href=""#""><i class=""flag-icon flag-icon-ng""></i> English</a><a class=""dropdown-item"" href=""#""><i class=""flag-icon flag-icon-cn""></i> Chinese</a><a class=""dropdown-item"" href=""#""><i class=""flag-icon flag-icon-ru""></i> Russian</a><a class=""dropdown-item"" href=""#""><i class=""flag-icon flag-icon-fr""></i> French</a><a class=""dropdown-item"" href=""#""><");
            WriteLiteral(@"i class=""flag-icon flag-icon-es""></i> Spanish</a></div>
                            </div>
                        </li>
                    </ul>
                    <ul class=""nav navbar-nav float-right"">
                        <li class=""dropdown dropdown-user nav-item"">
                            <a class=""dropdown-toggle nav-link dropdown-user-link"" href=""#"" data-toggle=""dropdown"">             <span class=""avatar avatar-online""><img src=""theme-assets/images/portrait/small/devon.JPG"" alt=""avatar""><i></i></span></a>
                            <div class=""dropdown-menu dropdown-menu-right"">
                                <div class=""arrow_box_right"">
                                    <a class=""dropdown-item"" href=""#""><span class=""avatar avatar-online""><img src=""theme-assets/images/portrait/small/devon.JPG"" alt=""avatar""><span class=""user-name text-bold-700 ml-1"">Ekpokpobe<br />Davidson</span></span></a>
                                    <div class=""dropdown-divider""></div><a class=""dropdown");
            WriteLiteral(@"-item"" href=""#""><i class=""ft-user""></i> Edit Profile</a><a class=""dropdown-item"" href=""#""><i class=""ft-mail""></i> My Inbox</a><a class=""dropdown-item"" href=""#""><i class=""ft-check-square""></i> Task</a><a class=""dropdown-item"" href=""#""><i class=""ft-message-square""></i> Chats</a>
                                    <div class=""dropdown-divider""></div><a class=""dropdown-item"" href=""#""><i class=""ft-power""></i> Logout</a>
                                </div>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </nav>

    <!-- ////////////////////////////////////////////////////////////////////////////-->
    <!-- <div class=""main-menu menu-fixed menu-light menu-accordion    menu-shadow "" data-scroll-to-active=""true"" data-img=""theme-assets/images/backgrounds/02.jpg"">
         <div class=""navbar-header"">
             <ul class=""nav navbar-nav flex-row"">
                 <li class=""nav-item mr-auto"">
 ");
            WriteLiteral(@"                    <a class=""navbar-brand"" href=""index.html"">

                         <h3 class=""brand-text"">MyBOOK WEB</h3>
                     </a>
                 </li>
                 <li class=""nav-item d-md-none""><a class=""nav-link close-navbar""><i class=""ft-x""></i></a></li>
             </ul>
         </div>
         <div class=""main-menu-content"">
             <ul class=""navigation navigation-main"" id=""main-menu-navigation"" data-menu=""menu-navigation"">
                 <li class=""active"">
                     <a href=""Author""><i class=""ft-user""></i><span class=""menu-title"" data-i18n="""">Author</span></a>
                 </li>
                 <li class="" nav-item"">
                     <a href=""charts.html""><i class=""ft-book""></i><span class=""menu-title"" data-i18n="""">Book</span></a>
                 </li>
                 <li class="" nav-item"">
                     <a href=""icons.html""><i class=""ft-bookmark""></i><span class=""menu-title"" data-i18n="""">Genre</span></a>
           ");
            WriteLiteral(@"      </li>
                 <li class="" nav-item"">
                     <a href=""cards.html""><i class=""ft-user""></i><span class=""menu-title"" data-i18n="""">Publisher</span></a>
                 </li>
                 <li class="" nav-item"">
                     <a href=""buttons.html""><i class=""ft-folder""></i><span class=""menu-title"" data-i18n="""">Category</span></a>
                 </li>
                 <li class="" nav-item"">
                     <a href=""typography.html""><i class=""ft-user""></i><span class=""menu-title"" data-i18n="""">User</span></a>
                 </li>
                 <li class="" nav-item"">
                     <a href=""tables.html""><i class=""ft-user""></i><span class=""menu-title"" data-i18n="""">AppUser</span></a>
                 </li>
                 <li class="" nav-item"">
                     <a href=""form-elements.html""><i class=""ft-star""></i><span class=""menu-title"" data-i18n="""">AppRole</span></a>
                 </li>
             </ul>
             <div class=""navigati");
            WriteLiteral(@"on-background""></div>
         </div>
     </div>-->

    <div class=""app-content content"">
        <div class=""content-wrapper"">
            <div class=""content-wrapper-before""></div>
            <div class=""content-header row"">
                <div class=""content-header-left col-md-4 col-12 mb-2"">
                    <h3 class=""content-header-title"">Tables</h3>
                </div>
                <div class=""content-header-right col-md-8 col-12"">
                    <div class=""breadcrumbs-top float-md-right"">
                        <div class=""breadcrumb-wrapper mr-1"">
                            <ol class=""breadcrumb"">
                                <li class=""breadcrumb-item"">
                                    <a href=""index.html"">Home</a>
                                </li>
                                <li class=""breadcrumb-item active"">
                                    Tables
                                </li>
                            </ol>
                   ");
            WriteLiteral(@"     </div>
                    </div>
                </div>
            </div>
            <div class=""content-body"">
                <!-- Basic Tables start -->
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""card"">
                            <div class=""card-header"">
                                <h4 class=""card-title"">Authors</h4>
                                <a class=""heading-elements-toggle""><i class=""la la-ellipsis-v font-medium-3""></i></a>
                                <div class=""heading-elements"">
                                    <ul class=""list-inline mb-0"">
                                        <li><a data-action=""collapse""><i class=""ft-minus""></i></a></li>
                                        <li><a data-action=""reload""><i class=""ft-rotate-cw""></i></a></li>
                                        <li><a data-action=""expand""><i class=""ft-maximize""></i></a></li>
                                        <");
            WriteLiteral(@"li><a data-action=""close""><i class=""ft-x""></i></a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class=""card-content collapse show"">
                                <div class=""card-body"">
                                    <div class=""col-md-12 col-12 align-self-center"">

                                        ");
            EndContext();
            BeginContext(9344, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "835a5a1f5a8b4939b593072ca9732d54", async() => {
                BeginContext(9442, 45, true);
                WriteLiteral("<i class=\"mdi mdi-plus-circle\"></i>New Author");
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
            BeginContext(9491, 917, true);
            WriteLiteral(@"
                                    </div>
                                    <div class=""table-responsive"">
                                        <table class=""table"">
                                            <thead>
                                                <tr>
                                                    <th>#</th>
                                                    <th>Title</th>
                                                    <th>Name</th>
                                                    <th>CreatedBy</th>
                                                    <th>DateCreated</th>
                                                    <th></th>
                                                    <th></th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
            EndContext();
#line 158 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Author\Index.cshtml"
                                                 foreach (var author in Model)
                                                {

#line default
#line hidden
            BeginContext(10539, 122, true);
            WriteLiteral("                                                <tr>\r\n                                                    <td scope=\"row\">");
            EndContext();
            BeginContext(10662, 9, false);
#line 161 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Author\Index.cshtml"
                                                               Write(author.Id);

#line default
#line hidden
            EndContext();
            BeginContext(10671, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(10735, 12, false);
#line 162 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Author\Index.cshtml"
                                                   Write(author.Title);

#line default
#line hidden
            EndContext();
            BeginContext(10747, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(10811, 11, false);
#line 163 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Author\Index.cshtml"
                                                   Write(author.Name);

#line default
#line hidden
            EndContext();
            BeginContext(10822, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(10886, 16, false);
#line 164 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Author\Index.cshtml"
                                                   Write(author.CreatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(10902, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(10966, 18, false);
#line 165 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Author\Index.cshtml"
                                                   Write(author.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(10984, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(11047, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6ed38c40c69468a992ec283836ccce2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 166 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Author\Index.cshtml"
                                                                                                                                    WriteLiteral(author.Id);

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
            BeginContext(11170, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(11233, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e092cc6153864df7bbd3687a2c5f4d7d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 167 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Author\Index.cshtml"
                                                                                                                                        WriteLiteral(author.Id);

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
            BeginContext(11360, 116, true);
            WriteLiteral("</td>\r\n                                                    \r\n                                                </tr>\r\n");
            EndContext();
#line 170 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Author\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(11527, 2061, true);
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Basic Tables end -->
    <!-- ////////////////////////////////////////////////////////////////////////////-->
    <!--<footer class=""footer footer-static footer-light navbar-border navbar-shadow"">
            <div class=""clearfix blue-grey lighten-2 text-sm-center mb-0 px-2"">
                <span class=""float-md-left d-block d-md-inline-block"">2018  &copy; Copyright <a class=""text-bold-800 grey darken-2"" href=""https://themeselection.com"" target=""_blank"">ThemeSelection</a></span>
                <ul class=""list-inline float-md-right d-block d-md-inline-blockd-none d-lg-block mb-0"">
                    <li class=""list-inline-item""><a class=""my-1""");
            WriteLiteral(@" href=""https://themeselection.com/"" target=""_blank""> More themes</a></li>
                    <li class=""list-inline-item""><a class=""my-1"" href=""https://themeselection.com/support"" target=""_blank""> Support</a></li>
                    <li class=""list-inline-item""><a class=""my-1"" href=""https://themeselection.com/products/chameleon-admin-modern-bootstrap-webapp-dashboard-html-template-ui-kit/"" target=""_blank""> Purchase</a></li>
                </ul>
            </div>
        </footer>
    -->
    <!-- BEGIN VENDOR JS-->
    <!--<script src=""theme-assets/vendors/js/vendors.min.js"" type=""text/javascript""></script>-->
    <!-- BEGIN VENDOR JS-->
    <!-- BEGIN PAGE VENDOR JS-->
    <!-- END PAGE VENDOR JS-->
    <!-- BEGIN CHAMELEON  JS-->
    <!--<script src=""theme-assets/js/core/app-menu-lite.js"" type=""text/javascript""></script>-->
    <!--script src=""theme-assets/js/core/app-lite.js"" type=""text/javascript""></script>--><
    <!-- END PAGE LEVEL JS-->
    <!--asp-controller=""Author"" asp-action=""C");
            WriteLiteral("reate\"-->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MybookWeb.Entities.Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591
