#pragma checksum "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea940382e68d8cfcd8bbf0e2f70f9e3fc798ce53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Listado), @"mvc.1.0.view", @"/Views/Personal/Listado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Personal/Listado.cshtml", typeof(AspNetCore.Views_Personal_Listado))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea940382e68d8cfcd8bbf0e2f70f9e3fc798ce53", @"/Views/Personal/Listado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e0224bf2afbd8e8ea08d54156c8c5660928715", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Listado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MCN.Models.Personal>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Activate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegistrarPersonal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
  
    ViewData["Title"] = "ListadoPersonal";

#line default
#line hidden
            BeginContext(94, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(123, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15e0dd42c7d841209efbd84967eabc70", async() => {
                BeginContext(129, 89, true);
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
            BeginContext(225, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(227, 4410, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5df71c817244e4da6ab03ccb58eed82", async() => {
                BeginContext(233, 583, true);
                WriteLiteral(@"

    <div class=""row"">
        <h4>Personal Registrado</h4>
        <div class=""col-lg-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    Información del Personal de la Revista MCYN
                </div>
                <div class=""panel-body"">
                    <table width=""100%"" class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                        <thead>
                            <tr>
                                <th>
                                    ");
                EndContext();
                BeginContext(817, 43, false);
#line 28 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                               Write(Html.DisplayNameFor(model => model.NombreP));

#line default
#line hidden
                EndContext();
                BeginContext(860, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(976, 45, false);
#line 31 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                               Write(Html.DisplayNameFor(model => model.ApellidoP));

#line default
#line hidden
                EndContext();
                BeginContext(1021, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1137, 54, false);
#line 34 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                               Write(Html.DisplayNameFor(model => model.CorreoElectronicoP));

#line default
#line hidden
                EndContext();
                BeginContext(1191, 228, true);
                WriteLiteral("\r\n                                </th>\r\n                                <!--th>\r\n                                Institución\r\n                            </th>\r\n                            <th>\r\n                                ");
                EndContext();
                BeginContext(1420, 49, false);
#line 40 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                           Write(Html.DisplayNameFor(model => model.RExtencionesP));

#line default
#line hidden
                EndContext();
                BeginContext(1469, 113, true);
                WriteLiteral("\r\n                            </th-->\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1583, 41, false);
#line 43 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                               Write(Html.DisplayNameFor(model => model.TipoP));

#line default
#line hidden
                EndContext();
                BeginContext(1624, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1740, 42, false);
#line 46 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
                EndContext();
                BeginContext(1782, 194, true);
                WriteLiteral("\r\n                                </th>\r\n\r\n                                <th>Acción</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
                EndContext();
#line 53 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
                BeginContext(2065, 139, true);
                WriteLiteral("                                <tr class=\"odd gradeX\">\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2205, 42, false);
#line 57 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.NombreP));

#line default
#line hidden
                EndContext();
                BeginContext(2247, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2375, 44, false);
#line 60 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ApellidoP));

#line default
#line hidden
                EndContext();
                BeginContext(2419, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2547, 53, false);
#line 63 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CorreoElectronicoP));

#line default
#line hidden
                EndContext();
                BeginContext(2600, 126, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <!--td>\r\n                                    ");
                EndContext();
                BeginContext(2727, 99, false);
#line 66 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                               Write(Html.DisplayFor(modelItem => item.RExtencionesPNavigation.RInstitucionesNavigation.NombreInstituto));

#line default
#line hidden
                EndContext();
                BeginContext(2826, 115, true);
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
                EndContext();
                BeginContext(2942, 74, false);
#line 69 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                               Write(Html.DisplayFor(modelItem => item.RExtencionesPNavigation.NombreExtencion));

#line default
#line hidden
                EndContext();
                BeginContext(3016, 125, true);
                WriteLiteral("\r\n                                </td-->\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(3142, 63, false);
#line 72 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TipoPNavigation.TipoUsuarios));

#line default
#line hidden
                EndContext();
                BeginContext(3205, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(3333, 63, false);
#line 75 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.StatusNavigation.DescEstados));

#line default
#line hidden
                EndContext();
                BeginContext(3396, 155, true);
                WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        &nbsp;&nbsp; &nbsp;&nbsp; ");
                EndContext();
                BeginContext(3551, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35c362bc6eb749f789b4896fea94a4f6", async() => {
                    BeginContext(3608, 28, true);
                    WriteLiteral("<i class=\"fa fa-list  \"></i>");
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
#line 79 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                                                                                             WriteLiteral(item.IdPersonal);

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
                BeginContext(3640, 28, true);
                WriteLiteral(" &nbsp;&nbsp; &nbsp;&nbsp;\r\n");
                EndContext();
#line 80 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                                         if (item.StatusNavigation.IdEstado == 1)
                                        {

#line default
#line hidden
                BeginContext(3794, 44, true);
                WriteLiteral("                                            ");
                EndContext();
                BeginContext(3838, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c787ee06103145e0bd05c89104b4a314", async() => {
                    BeginContext(3893, 29, true);
                    WriteLiteral(" <i class=\"fa fa-times\"></i> ");
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
#line 82 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                                                                     WriteLiteral(item.IdPersonal);

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
                BeginContext(3926, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 83 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
                BeginContext(4060, 44, true);
                WriteLiteral("                                            ");
                EndContext();
                BeginContext(4104, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fcd62f8800441ad8dc4dab795128169", async() => {
                    BeginContext(4161, 28, true);
                    WriteLiteral(" <i class=\"fa fa-check\"></i>");
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
#line 86 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                                                                       WriteLiteral(item.IdPersonal);

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
                BeginContext(4193, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 87 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                                        }

#line default
#line hidden
                BeginContext(4238, 82, true);
                WriteLiteral("                                    </td>\r\n                                </tr>\r\n");
                EndContext();
#line 90 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Personal\Listado.cshtml"
                            }

#line default
#line hidden
                BeginContext(4351, 155, true);
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <p>\r\n        ");
                EndContext();
                BeginContext(4506, 110, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a8b162a6d0045f09dc60f6ecd65f826", async() => {
                    BeginContext(4540, 72, true);
                    WriteLiteral("<button type=\"button\" class=\"btn btn-default\" >Agregar Personal</button>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4616, 14, true);
                WriteLiteral("\r\n    </p>\r\n\r\n");
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
            BeginContext(4637, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MCN.Models.Personal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
