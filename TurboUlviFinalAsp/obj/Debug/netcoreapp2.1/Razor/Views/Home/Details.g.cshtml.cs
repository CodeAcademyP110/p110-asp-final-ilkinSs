#pragma checksum "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2e39fd20775a701b244c40f7a4b6af5b4b1136e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\_ViewImports.cshtml"
using TurboUlviFinalAsp;

#line default
#line hidden
#line 2 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\_ViewImports.cshtml"
using TurboUlviFinalAsp.Models;

#line default
#line hidden
#line 3 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\_ViewImports.cshtml"
using TurboUlviFinalAsp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2e39fd20775a701b244c40f7a4b6af5b4b1136e", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b066c66750ffd22072c05f5f51e46aded1f6dabf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ElanImg img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("productBorder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var Number = 1;

#line default
#line hidden
            BeginContext(91, 146, true);
            WriteLiteral("\r\n\r\n    <section>\r\n        <div class=\"container\">\r\n            <div class=\"row\" style=\"background:black \">\r\n                <div class=\"col-6\">\r\n");
            EndContext();
            BeginContext(357, 100, true);
            WriteLiteral("                </div>\r\n                <div class=\"col-6\">\r\n                    <div class=\"row\">\r\n");
            EndContext();
#line 17 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                         foreach (var image in Model.Announcement.Images)
                        {

#line default
#line hidden
            BeginContext(559, 86, true);
            WriteLiteral("                            <div class=\"col-4 mt-3\">\r\n                                ");
            EndContext();
            BeginContext(645, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "338c627ed20f4f2b9680ec896d86a181", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 655, "~/image/", 655, 8, true);
#line 20 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 663, image.Name, 663, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(722, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 22 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(787, 325, true);
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""row"">
                <h1>Normal Elan</h1>
            </div>
            <div class=""row"">
                <div class=""col-4"" style=""border:1px solid black"">
                    <span style=""font-weight: bold"">Price</span>:");
            EndContext();
            BeginContext(1113, 24, false);
#line 31 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                                                            Write(Model.Announcement.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1137, 162, true);
            WriteLiteral(" $\r\n                </div>\r\n                <div class=\"col-4\" style=\"border:1px solid black\">\r\n                    <span style=\"font-weight: bold\">Number</span>:");
            EndContext();
            BeginContext(1300, 46, false);
#line 34 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                                                             Write(Model.Announcement.ApplicationUser.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1346, 94, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-4\" style=\"border:1px solid black\">\r\n");
            EndContext();
            BeginContext(1495, 133, true);
            WriteLiteral("                    <br>\r\n                    Yeniləndi: 23 İyul 2019\r\n                    <br>\r\n                    Elanın nömrəsi: ");
            EndContext();
            BeginContext(1629, 21, false);
#line 41 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                               Write(Model.Announcement.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1650, 308, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""row"">
                <div class=""col-6"">
                    <table class=""table"">
                        <tbody>
                            <tr>
                                <td>Model</td>
                                <td>");
            EndContext();
            BeginContext(1959, 29, false);
#line 50 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                               Write(Model.Announcement.Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1988, 160, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Şəhər</td>\r\n                                <td>");
            EndContext();
            BeginContext(2149, 28, false);
#line 54 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                               Write(Model.Announcement.City.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2177, 162, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <td>Marka</td>\r\n                                <td>");
            EndContext();
            BeginContext(2340, 35, false);
#line 59 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                               Write(Model.Announcement.Model.marca.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2375, 168, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Buraxılış ili</td>\r\n                                <td>");
            EndContext();
            BeginContext(2544, 68, false);
#line 63 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                               Write(String.Format("{0:yyyy-MM-dd}", Model.Announcement.PublishDate.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2612, 163, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Ban növü</td>\r\n                                <td>");
            EndContext();
            BeginContext(2776, 31, false);
#line 67 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                               Write(Model.Announcement.CarBody.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2807, 159, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Rəng</td>\r\n                                <td>");
            EndContext();
            BeginContext(2967, 29, false);
#line 71 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                               Write(Model.Announcement.Color.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2996, 171, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Mühərrikin həcmi</td>\r\n                                <td>");
            EndContext();
            BeginContext(3169, 36, false);
#line 75 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                                Write(Model.Announcement.Motor.Hecmi / 100);

#line default
#line hidden
            EndContext();
            BeginContext(3206, 171, true);
            WriteLiteral(" L</td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <td>Yanacaq növü</td>\r\n                                <td>");
            EndContext();
            BeginContext(3378, 28, false);
#line 80 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                               Write(Model.Announcement.Fuel.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3406, 160, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Yürüş</td>\r\n                                <td>");
            EndContext();
            BeginContext(3567, 27, false);
#line 84 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                               Write(Model.Announcement.Distance);

#line default
#line hidden
            EndContext();
            BeginContext(3594, 173, true);
            WriteLiteral(" km</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Sürətlər qutusu</td>\r\n                                <td>");
            EndContext();
            BeginContext(3768, 31, false);
#line 88 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                               Write(Model.Announcement.GearBox.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3799, 162, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Ötürücü</td>\r\n                                <td>");
            EndContext();
            BeginContext(3962, 36, false);
#line 92 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                               Write(Model.Announcement.Transmission.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3998, 161, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Qiymət</td>\r\n                                <td>");
            EndContext();
            BeginContext(4160, 24, false);
#line 96 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                               Write(Model.Announcement.Price);

#line default
#line hidden
            EndContext();
            BeginContext(4184, 195, true);
            WriteLiteral(" $</td>\r\n                            </tr>\r\n\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n                <div class=\"col-6\">\r\n                    <h3>");
            EndContext();
            BeginContext(4380, 28, false);
#line 103 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                   Write(Model.Announcement.ShortInfo);

#line default
#line hidden
            EndContext();
            BeginContext(4408, 30, true);
            WriteLiteral("</h3>\r\n                    <p>");
            EndContext();
            BeginContext(4439, 27, false);
#line 104 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                  Write(Model.Announcement.FullInfo);

#line default
#line hidden
            EndContext();
            BeginContext(4466, 159, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n          </div>\r\n    </section>\r\n}\r\n\r\n<section>\r\n    <div class=\"wrapper\">\r\n        <div class=\"products\">\r\n");
            EndContext();
#line 114 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
             foreach (var item in Model.Announcements)
            {

#line default
#line hidden
            BeginContext(4696, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(4712, 1816, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e76db627a94dedbe76069b03d2fb89", async() => {
                BeginContext(4804, 132, true);
                WriteLiteral("\r\n                    <div class=\"onliCar\">\r\n                        <i class=\"far fa-heart likeIcon\"></i>\r\n                        ");
                EndContext();
                BeginContext(4936, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "71f4a4ec8e0044df9961e8fac7855c03", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4946, "~/image/", 4946, 8, true);
#line 119 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 4954, item.PhotoUrl, 4954, 14, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4977, 82, true);
                WriteLiteral("\r\n                        <div class=\"productPrice\">\r\n                            ");
                EndContext();
                BeginContext(5060, 10, false);
#line 121 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                       Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(5070, 153, true);
                WriteLiteral(" <span>AZN</span>\r\n                        </div>\r\n                        <div class=\"productsInfo\">\r\n                            <span class=\"carName\">");
                EndContext();
                BeginContext(5224, 21, false);
#line 124 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                                             Write(item.Model.marca.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5245, 59, true);
                WriteLiteral("</span>\r\n                            <span class=\"carName\">");
                EndContext();
                BeginContext(5305, 15, false);
#line 125 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                                             Write(item.Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5320, 146, true);
                WriteLiteral("</span>\r\n                            <div class=\"carInfo\">\r\n                                <p class=\"year\">\r\n                                    ");
                EndContext();
                BeginContext(5467, 24, false);
#line 128 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                               Write(item.GraduationYear.Year);

#line default
#line hidden
                EndContext();
                BeginContext(5491, 181, true);
                WriteLiteral(" il\r\n                                    <span></span>\r\n                                </p>\r\n                                <p class=\"engin\">\r\n                                    ");
                EndContext();
                BeginContext(5674, 22, false);
#line 132 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                                Write(item.Motor.Hecmi / 100);

#line default
#line hidden
                EndContext();
                BeginContext(5697, 139, true);
                WriteLiteral(" L\r\n                                    <span></span>\r\n                                </p>\r\n                                <p class=\"km\">");
                EndContext();
                BeginContext(5837, 13, false);
#line 135 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                                         Write(item.Distance);

#line default
#line hidden
                EndContext();
                BeginContext(5850, 130, true);
                WriteLiteral(" km </p>\r\n                            </div>\r\n                            <div class=\"enterDay\">\r\n                                ");
                EndContext();
                BeginContext(5981, 14, false);
#line 138 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                           Write(item.City.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5995, 1, true);
                WriteLiteral(",");
                EndContext();
                BeginContext(5997, 49, false);
#line 138 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                                           Write(String.Format("{0:MM/dd/yyyy}", item.PublishDate));

#line default
#line hidden
                EndContext();
                BeginContext(6046, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 139 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                                 if (item.IsVip == true)
                                {

#line default
#line hidden
                BeginContext(6141, 64, true);
                WriteLiteral("                                    <i class=\"fas fa-gem\"></i>\r\n");
                EndContext();
#line 142 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(6313, 64, true);
                WriteLiteral("                                    <i class=\"fal fa-gem\"></i>\r\n");
                EndContext();
#line 146 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                                }

#line default
#line hidden
                BeginContext(6412, 112, true);
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 116 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
                                                                                      WriteLiteral(item.Id);

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
            BeginContext(6528, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 151 "C:\Users\Admin\source\repos\TurboUlviFinalAsp\TurboUlviFinalAsp\Views\Home\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(6545, 73, true);
            WriteLiteral("        </div>\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
