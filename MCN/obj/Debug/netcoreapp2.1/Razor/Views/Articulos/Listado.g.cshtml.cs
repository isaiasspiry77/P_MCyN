#pragma checksum "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24b60b4157c4ab45109c0d762670c4d676b28908"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articulos_Listado), @"mvc.1.0.view", @"/Views/Articulos/Listado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Articulos/Listado.cshtml", typeof(AspNetCore.Views_Articulos_Listado))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24b60b4157c4ab45109c0d762670c4d676b28908", @"/Views/Articulos/Listado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e0224bf2afbd8e8ea08d54156c8c5660928715", @"/Views/_ViewImports.cshtml")]
    public class Views_Articulos_Listado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MCN.Models.Articulo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Asignacion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetalleArticulo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
  
    ViewData["Title"] = "ListadoArticulos";
    ViewData["Tipo"] = ViewData["tipo"];

    int i = 0;

#line default
#line hidden
            BeginContext(155, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(184, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a92473687e348dd966d722d3e4d0d7b", async() => {
                BeginContext(190, 89, true);
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
            BeginContext(286, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(288, 5067, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec078cc0a62840cab1a1b8c674463715", async() => {
                BeginContext(294, 570, true);
                WriteLiteral(@"
    <div class=""row"">
        <h4>Articulos Publicados</h4>
        <div class=""col-lg-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    Listado de Articulos Publicados
                </div>
                <div class=""panel-body"">
                    <table width=""100%"" class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                        <thead>
                            <tr>
                                <th>
                                    ");
                EndContext();
                BeginContext(865, 50, false);
#line 30 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                               Write(Html.DisplayNameFor(model => model.TituloArticulo));

#line default
#line hidden
                EndContext();
                BeginContext(915, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1031, 53, false);
#line 33 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                               Write(Html.DisplayNameFor(model => model.FechaPublicacionA));

#line default
#line hidden
                EndContext();
                BeginContext(1084, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1200, 50, false);
#line 36 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                               Write(Html.DisplayNameFor(model => model.RutaDocumentoA));

#line default
#line hidden
                EndContext();
                BeginContext(1250, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1366, 52, false);
#line 39 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                               Write(Html.DisplayNameFor(model => model.RutaZipImagenesA));

#line default
#line hidden
                EndContext();
                BeginContext(1418, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1534, 52, false);
#line 42 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                               Write(Html.DisplayNameFor(model => model.ComentariosAutor));

#line default
#line hidden
                EndContext();
                BeginContext(1586, 41, true);
                WriteLiteral("\r\n                                </th>\r\n");
                EndContext();
#line 44 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                 if (i != 0)
                                {

#line default
#line hidden
                BeginContext(1708, 82, true);
                WriteLiteral("                                    <th>\r\n                                        ");
                EndContext();
                BeginContext(1791, 49, false);
#line 47 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FechaEdicionA));

#line default
#line hidden
                EndContext();
                BeginContext(1840, 45, true);
                WriteLiteral("\r\n                                    </th>\r\n");
                EndContext();
#line 49 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                }

#line default
#line hidden
                BeginContext(1920, 74, true);
                WriteLiteral("                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1995, 42, false);
#line 51 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                               Write(Html.DisplayNameFor(model => model.RAutor));

#line default
#line hidden
                EndContext();
                BeginContext(2037, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(2153, 42, false);
#line 54 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
                EndContext();
                BeginContext(2195, 192, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>Acción</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
                EndContext();
#line 60 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
                BeginContext(2476, 120, true);
                WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2597, 49, false);
#line 64 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TituloArticulo));

#line default
#line hidden
                EndContext();
                BeginContext(2646, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2774, 52, false);
#line 67 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.FechaPublicacionA));

#line default
#line hidden
                EndContext();
                BeginContext(2826, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2954, 153, false);
#line 70 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                   Write(Html.ActionLink("Articulos", "DownloadPdf", new { fullPath = (string)item.RutaDocumentoA }, new { @class = "btn btn-success btn-block fa fa-download " }));

#line default
#line hidden
                EndContext();
                BeginContext(3107, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(3235, 155, false);
#line 73 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                   Write(Html.ActionLink("Articulos", "DownloadZip", new { fullPath = (string)item.RutaZipImagenesA }, new { @class = "btn btn-success btn-block fa fa-download " }));

#line default
#line hidden
                EndContext();
                BeginContext(3390, 147, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td >\r\n                                        <p align=\"justify\">");
                EndContext();
                BeginContext(3538, 51, false);
#line 76 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.ComentariosAutor));

#line default
#line hidden
                EndContext();
                BeginContext(3589, 50, true);
                WriteLiteral("</p> \r\n                                    </td>\r\n");
                EndContext();
#line 78 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                     if (item.FechaEdicionA != null)
                                    {
                                        i = 1;

#line default
#line hidden
                BeginContext(3796, 90, true);
                WriteLiteral("                                        <td>\r\n                                            ");
                EndContext();
                BeginContext(3887, 48, false);
#line 82 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.FechaEdicionA));

#line default
#line hidden
                EndContext();
                BeginContext(3935, 49, true);
                WriteLiteral("\r\n                                        </td>\r\n");
                EndContext();
#line 84 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                    }

#line default
#line hidden
                BeginContext(4023, 82, true);
                WriteLiteral("                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(4106, 59, false);
#line 86 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.RAutorNavigation.NombreA));

#line default
#line hidden
                EndContext();
                BeginContext(4165, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(4208, 62, false);
#line 87 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.RAutorNavigation.ApellidosA));

#line default
#line hidden
                EndContext();
                BeginContext(4270, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(4398, 63, false);
#line 90 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.StatusNavigation.DescEstados));

#line default
#line hidden
                EndContext();
                BeginContext(4461, 205, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <!--a asp-action=\"Retroalimentacion\" asp-controller=\"Articulos\" asp-route-id=\"");
                EndContext();
                BeginContext(4667, 15, false);
#line 93 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                                                                                                 Write(item.IdArticulo);

#line default
#line hidden
                EndContext();
                BeginContext(4682, 202, true);
                WriteLiteral("\">Retroalimentar</a-->\r\n                                        <!--a href=\"#\" id=\"retroalimentacion\" onclick=\"alerta(this.id)\" name=\"\">Retroalimentación</a--> \r\n                                        ");
                EndContext();
                BeginContext(4884, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0f346203f5f4afb806ded45dba43937", async() => {
                    BeginContext(4943, 15, true);
                    WriteLiteral("Asignar Revisor");
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
#line 95 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                                                     WriteLiteral(item.IdArticulo);

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
                BeginContext(4962, 44, true);
                WriteLiteral(" |\r\n                                        ");
                EndContext();
                BeginContext(5006, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8a71a33e8d04a479cacb741a556ff18", async() => {
                    BeginContext(5070, 21, true);
                    WriteLiteral("Detalles del Articulo");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 96 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                                                                          WriteLiteral(item.IdArticulo);

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
                BeginContext(5095, 86, true);
                WriteLiteral(" |\r\n                                    </td>\r\n                                </tr>\r\n");
                EndContext();
#line 99 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Listado.cshtml"
                            }

#line default
#line hidden
                BeginContext(5212, 136, true);
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
            BeginContext(5355, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MCN.Models.Articulo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
