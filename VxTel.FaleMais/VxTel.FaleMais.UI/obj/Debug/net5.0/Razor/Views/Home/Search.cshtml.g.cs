#pragma checksum "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c112cfde8b503044e97e1dcac7e5478f90ff1ea7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\_ViewImports.cshtml"
using VxTel.FaleMais.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\_ViewImports.cshtml"
using VxTel.FaleMais.Infra.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c112cfde8b503044e97e1dcac7e5478f90ff1ea7", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d5ba94048ef394a0cffe0a52b0a35e12c43877f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VxTel.FaleMais.Application.ViewModels.ExceedingMinuteViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Fale Mais";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>\r\n    <b>");
#nullable restore
#line 6 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> - Valor das Tarifas\r\n</h2>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div>\r\n            <div class=\"pull-left\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c112cfde8b503044e97e1dcac7e5478f90ff1ea74501", async() => {
                WriteLiteral("Calcular Novamente");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<br />
<div class=""panel panel-default"">
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>Origem</th>
                <th>Destino</th>
                <th>Tempo</th>
                <th>Plano FaleMais</th>
                <th>Com FaleMais</th>
                <th>Sem FaleMais</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 32 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Origin.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Destiny.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TimeInMinutes));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PlanDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 39 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml"
                     if (item.AmountPayableWithPlan != -1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 41 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AmountPayableWithPlan));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>-</td>\r\n");
#nullable restore
#line 47 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml"
                     if (item.AmountPayable != -1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 51 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AmountPayable));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 52 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>-</td>\r\n");
#nullable restore
#line 56 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 58 "C:\Users\Janus\Downloads\FaleMaisDocs\VxTel.FaleMais\VxTel.FaleMais.UI\Views\Home\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VxTel.FaleMais.Application.ViewModels.ExceedingMinuteViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591