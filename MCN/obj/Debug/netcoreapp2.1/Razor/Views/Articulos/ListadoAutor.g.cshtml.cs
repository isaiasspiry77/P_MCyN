#pragma checksum "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e43b4513e660339264be277be5359fbdebd12ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articulos_ListadoAutor), @"mvc.1.0.view", @"/Views/Articulos/ListadoAutor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Articulos/ListadoAutor.cshtml", typeof(AspNetCore.Views_Articulos_ListadoAutor))]
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
#line 1 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\_ViewImports.cshtml"
using MCN;

#line default
#line hidden
#line 2 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\_ViewImports.cshtml"
using MCN.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e43b4513e660339264be277be5359fbdebd12ac", @"/Views/Articulos/ListadoAutor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e0224bf2afbd8e8ea08d54156c8c5660928715", @"/Views/_ViewImports.cshtml")]
    public class Views_Articulos_ListadoAutor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MCN.Models.Articulo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
  
    ViewData["Title"] = "ListadoArticulosAutor";

    ViewData["Tipo"] = ViewData["tipo"];

#line default
#line hidden
            BeginContext(144, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(173, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08dcc19150ba46d3aec80f4626ae0ff7", async() => {
                BeginContext(179, 94, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ListadoAutor</title>\r\n");
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
            BeginContext(280, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(282, 4376, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fc6226682734cbf88d6ea53f8864be1", async() => {
                BeginContext(288, 569, true);
                WriteLiteral(@"
    <div class=""row"">
        <h4>Personal Registrado</h4>
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
                BeginContext(858, 50, false);
#line 29 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                               Write(Html.DisplayNameFor(model => model.TituloArticulo));

#line default
#line hidden
                EndContext();
                BeginContext(908, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1024, 53, false);
#line 32 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                               Write(Html.DisplayNameFor(model => model.FechaPublicacionA));

#line default
#line hidden
                EndContext();
                BeginContext(1077, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1193, 50, false);
#line 35 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                               Write(Html.DisplayNameFor(model => model.RutaDocumentoA));

#line default
#line hidden
                EndContext();
                BeginContext(1243, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1359, 52, false);
#line 38 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                               Write(Html.DisplayNameFor(model => model.RutaZipImagenesA));

#line default
#line hidden
                EndContext();
                BeginContext(1411, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1527, 52, false);
#line 41 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                               Write(Html.DisplayNameFor(model => model.ComentariosAutor));

#line default
#line hidden
                EndContext();
                BeginContext(1579, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1695, 49, false);
#line 44 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                               Write(Html.DisplayNameFor(model => model.FechaEdicionA));

#line default
#line hidden
                EndContext();
                BeginContext(1744, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1860, 42, false);
#line 47 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                               Write(Html.DisplayNameFor(model => model.RAutor));

#line default
#line hidden
                EndContext();
                BeginContext(1902, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(2018, 42, false);
#line 50 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
                EndContext();
                BeginContext(2060, 186, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
                EndContext();
#line 56 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
                BeginContext(2335, 120, true);
                WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2456, 49, false);
#line 60 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TituloArticulo));

#line default
#line hidden
                EndContext();
                BeginContext(2505, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2633, 52, false);
#line 63 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.FechaPublicacionA));

#line default
#line hidden
                EndContext();
                BeginContext(2685, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2813, 91, false);
#line 66 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                                   Write(Html.ActionLink("Articulos", "DownloadPdf", new{ fullPath = (string) item.RutaDocumentoA }));

#line default
#line hidden
                EndContext();
                BeginContext(2904, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(3032, 93, false);
#line 69 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                                   Write(Html.ActionLink("Articulos", "DownloadZip", new { fullPath = (string)item.RutaZipImagenesA }));

#line default
#line hidden
                EndContext();
                BeginContext(3125, 128, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td> \r\n                                        ");
                EndContext();
                BeginContext(3254, 51, false);
#line 72 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ComentariosAutor));

#line default
#line hidden
                EndContext();
                BeginContext(3305, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(3433, 48, false);
#line 75 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.FechaEdicionA));

#line default
#line hidden
                EndContext();
                BeginContext(3481, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(3609, 62, false);
#line 78 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.RAutorNavigation.ApellidosA));

#line default
#line hidden
                EndContext();
                BeginContext(3671, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(3799, 60, false);
#line 81 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.StatusNavigation.Lestados));

#line default
#line hidden
                EndContext();
                BeginContext(3859, 151, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        &nbsp;&nbsp;&nbsp;&nbsp;");
                EndContext();
                BeginContext(4010, 85, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c127a185de845ed912b4cab136ca101", async() => {
                    BeginContext(4063, 28, true);
                    WriteLiteral("<i class=\"fa fa-pencil\"></i>");
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
#line 84 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
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
                BeginContext(4095, 66, true);
                WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;\r\n                                        ");
                EndContext();
                BeginContext(4161, 86, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b93a17c47ed4f7cb8ee36ced95173bd", async() => {
                    BeginContext(4217, 26, true);
                    WriteLiteral("<i class=\"fa fa-list\"></i>");
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
#line 85 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
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
                BeginContext(4247, 66, true);
                WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;\r\n                                        ");
                EndContext();
                BeginContext(4313, 87, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "469306ab856f423491887a24d096f8c1", async() => {
                    BeginContext(4368, 28, true);
                    WriteLiteral(" <i class=\"fa fa-times\"></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 86 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
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
                BeginContext(4400, 84, true);
                WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
                EndContext();
#line 89 "C:\Users\rafao\Source\Repos\P_MCyN\MCN\Views\Articulos\ListadoAutor.cshtml"
                            }

#line default
#line hidden
                BeginContext(4515, 136, true);
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
            BeginContext(4658, 9, true);
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
