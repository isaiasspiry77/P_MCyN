#pragma checksum "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Autores\Listado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8169009c0967741067d2acb6932afa27803efb3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autores_Listado), @"mvc.1.0.view", @"/Views/Autores/Listado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Autores/Listado.cshtml", typeof(AspNetCore.Views_Autores_Listado))]
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
#line 1 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\_ViewImports.cshtml"
using MCN;

#line default
#line hidden
#line 2 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\_ViewImports.cshtml"
using MCN.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8169009c0967741067d2acb6932afa27803efb3c", @"/Views/Autores/Listado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e0224bf2afbd8e8ea08d54156c8c5660928715", @"/Views/_ViewImports.cshtml")]
    public class Views_Autores_Listado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MCN.Models.Autores>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Autores\Listado.cshtml"
  
    ViewData["Title"] = "ListadoAutores";
    ViewData["Tipo"] = ViewData["tipo"];

#line default
#line hidden
            BeginContext(134, 31, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(165, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4dea953e3c04b35997e7b89e95cf3a3", async() => {
                BeginContext(171, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Listado</title>\r\n");
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
            BeginContext(267, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(269, 2310, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff73e9b025f54a0a8a97ff2d99342ded", async() => {
                BeginContext(275, 603, true);
                WriteLiteral(@"

    <div class=""row"">
        <h4>Autores Registrados</h4>
        <div class=""col-lg-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    Información de lo Autores Activos Registrados en la pagina MCYN
                </div>
                <div class=""panel-body"">
                    <table width=""100%"" class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                        <thead>
                            <tr>
                                <th>
                                    ");
                EndContext();
                BeginContext(879, 43, false);
#line 30 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Autores\Listado.cshtml"
                               Write(Html.DisplayNameFor(model => model.NombreA));

#line default
#line hidden
                EndContext();
                BeginContext(922, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1038, 46, false);
#line 33 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Autores\Listado.cshtml"
                               Write(Html.DisplayNameFor(model => model.ApellidosA));

#line default
#line hidden
                EndContext();
                BeginContext(1084, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1200, 54, false);
#line 36 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Autores\Listado.cshtml"
                               Write(Html.DisplayNameFor(model => model.CorreoElectronicoA));

#line default
#line hidden
                EndContext();
                BeginContext(1254, 192, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>Acción</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
                EndContext();
#line 42 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Autores\Listado.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
                BeginContext(1535, 139, true);
                WriteLiteral("                                <tr class=\"odd gradeX\">\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(1675, 42, false);
#line 46 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Autores\Listado.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.NombreA));

#line default
#line hidden
                EndContext();
                BeginContext(1717, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(1845, 45, false);
#line 49 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Autores\Listado.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ApellidosA));

#line default
#line hidden
                EndContext();
                BeginContext(1890, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2018, 53, false);
#line 52 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Autores\Listado.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CorreoElectronicoA));

#line default
#line hidden
                EndContext();
                BeginContext(2071, 128, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                         ");
                EndContext();
                BeginContext(2199, 122, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8549bacd39654acaa7b1d816f8e7c845", async() => {
                    BeginContext(2253, 64, true);
                    WriteLiteral("<button type=\"button\" class=\"btn btn-danger\" > Eliminar</button>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 55 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Autores\Listado.cshtml"
                                                                  WriteLiteral(item.IdAutores);

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
                BeginContext(2321, 84, true);
                WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
                EndContext();
#line 58 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Autores\Listado.cshtml"
                            }

#line default
#line hidden
                BeginContext(2436, 136, true);
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(2579, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MCN.Models.Autores>> Html { get; private set; }
    }
}
#pragma warning restore 1591
