#pragma checksum "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54f894efb6588c211e3974ba8d8931b3d9e8a57e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Detalles), @"mvc.1.0.view", @"/Views/Personal/Detalles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Personal/Detalles.cshtml", typeof(AspNetCore.Views_Personal_Detalles))]
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
#line 1 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\_ViewImports.cshtml"
using MCN;

#line default
#line hidden
#line 2 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\_ViewImports.cshtml"
using MCN.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54f894efb6588c211e3974ba8d8931b3d9e8a57e", @"/Views/Personal/Detalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e0224bf2afbd8e8ea08d54156c8c5660928715", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Detalles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MCN.Models.Personal>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Listado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml"
  
    ViewData["Title"] = "DetallePersonal";

#line default
#line hidden
            BeginContext(81, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(110, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c44e8c76ffc04ad291292abf0fa9a53a", async() => {
                BeginContext(116, 90, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Detalles</title>\r\n");
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
            BeginContext(213, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(215, 2538, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32d64e2137064bea939f6aed3a9575a9", async() => {
                BeginContext(221, 368, true);
                WriteLiteral(@"

    <div class=""row"">
        <br />
        <div class=""col-lg-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h4>Información del Personal</h4>

                </div>
                <br />
                <dl class=""dl-horizontal "">
                    <dt>
                        ");
                EndContext();
                BeginContext(590, 43, false);
#line 27 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml"
                   Write(Html.DisplayNameFor(model => model.NombreP));

#line default
#line hidden
                EndContext();
                BeginContext(633, 80, true);
                WriteLiteral(":\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(714, 39, false);
#line 30 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml"
                   Write(Html.DisplayFor(model => model.NombreP));

#line default
#line hidden
                EndContext();
                BeginContext(753, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(780, 41, false);
#line 31 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml"
                   Write(Html.DisplayFor(model => model.ApellidoP));

#line default
#line hidden
                EndContext();
                BeginContext(821, 79, true);
                WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                EndContext();
                BeginContext(901, 54, false);
#line 34 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml"
                   Write(Html.DisplayNameFor(model => model.CorreoElectronicoP));

#line default
#line hidden
                EndContext();
                BeginContext(955, 80, true);
                WriteLiteral(":\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(1036, 50, false);
#line 37 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml"
                   Write(Html.DisplayFor(model => model.CorreoElectronicoP));

#line default
#line hidden
                EndContext();
                BeginContext(1086, 79, true);
                WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                EndContext();
                BeginContext(1166, 49, false);
#line 40 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml"
                   Write(Html.DisplayNameFor(model => model.RExtencionesP));

#line default
#line hidden
                EndContext();
                BeginContext(1215, 80, true);
                WriteLiteral(":\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(1296, 71, false);
#line 43 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml"
                   Write(Html.DisplayFor(model => model.RExtencionesPNavigation.NombreExtencion));

#line default
#line hidden
                EndContext();
                BeginContext(1367, 79, true);
                WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                EndContext();
                BeginContext(1447, 49, false);
#line 46 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml"
                   Write(Html.DisplayNameFor(model => model.RGradoEstudio));

#line default
#line hidden
                EndContext();
                BeginContext(1496, 80, true);
                WriteLiteral(":\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(1577, 68, false);
#line 49 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml"
                   Write(Html.DisplayFor(model => model.RGradoEstudioNavigation.NivelEstudio));

#line default
#line hidden
                EndContext();
                BeginContext(1645, 79, true);
                WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                EndContext();
                BeginContext(1725, 49, false);
#line 52 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml"
                   Write(Html.DisplayNameFor(model => model.RLineaTrabajo));

#line default
#line hidden
                EndContext();
                BeginContext(1774, 80, true);
                WriteLiteral(":\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(1855, 69, false);
#line 55 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml"
                   Write(Html.DisplayFor(model => model.RLineaTrabajoNavigation.LineasTrabajo));

#line default
#line hidden
                EndContext();
                BeginContext(1924, 79, true);
                WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                EndContext();
                BeginContext(2004, 42, false);
#line 58 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml"
                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
                EndContext();
                BeginContext(2046, 80, true);
                WriteLiteral(":\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(2127, 60, false);
#line 61 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml"
                   Write(Html.DisplayFor(model => model.StatusNavigation.DescEstados));

#line default
#line hidden
                EndContext();
                BeginContext(2187, 79, true);
                WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                EndContext();
                BeginContext(2267, 41, false);
#line 64 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml"
                   Write(Html.DisplayNameFor(model => model.TipoP));

#line default
#line hidden
                EndContext();
                BeginContext(2308, 80, true);
                WriteLiteral(":\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(2389, 60, false);
#line 67 "C:\Users\rafao\source\repos\P_MCyN\MCN\Views\Personal\Detalles.cshtml"
                   Write(Html.DisplayFor(model => model.TipoPNavigation.TipoUsuarios));

#line default
#line hidden
                EndContext();
                BeginContext(2449, 169, true);
                WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n                </div>\r\n            </div>\r\n        \r\n                <div>\r\n                    ");
                EndContext();
                BeginContext(2618, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff56b4736e0e490dbc5d6da895811286", async() => {
                    BeginContext(2642, 74, true);
                    WriteLiteral("<button type=\"button\" class=\"btn btn-default\">Regresar al Listado</button>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2720, 26, true);
                WriteLiteral("\r\n                </div>\r\n");
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
            BeginContext(2753, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MCN.Models.Personal> Html { get; private set; }
    }
}
#pragma warning restore 1591
