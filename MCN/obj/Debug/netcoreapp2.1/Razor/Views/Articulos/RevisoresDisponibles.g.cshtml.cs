#pragma checksum "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94580015aac418d46cb38ef00294061e49bcda15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articulos_RevisoresDisponibles), @"mvc.1.0.view", @"/Views/Articulos/RevisoresDisponibles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Articulos/RevisoresDisponibles.cshtml", typeof(AspNetCore.Views_Articulos_RevisoresDisponibles))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94580015aac418d46cb38ef00294061e49bcda15", @"/Views/Articulos/RevisoresDisponibles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e0224bf2afbd8e8ea08d54156c8c5660928715", @"/Views/_ViewImports.cshtml")]
    public class Views_Articulos_RevisoresDisponibles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MCN.Models.Personal>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
  
    ViewData["Title"] = "AsignarArticuloRevisores";
    ViewData["Tipo"] = ViewData["tipo"];
    int id_arti = (int)ViewData["idArt"];
    string comentario = (string)ViewData["coment"];

#line default
#line hidden
            BeginContext(241, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(268, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd341d6dc5b94f2d905d0991594bd7e9", async() => {
                BeginContext(274, 102, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>RevisoresDisponibles</title>\r\n");
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
            BeginContext(383, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(385, 5031, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b025c1428ca64cda9b8d226050d309f0", async() => {
                BeginContext(391, 37, true);
                WriteLiteral("\r\n    <input type=\"hidden\" id=\"id_ar\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 428, "\"", 444, 1);
#line 17 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
WriteAttributeValue("", 436, id_arti, 436, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(445, 39, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"come\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 484, "\"", 503, 1);
#line 18 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
WriteAttributeValue("", 492, comentario, 492, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(504, 566, true);
                WriteLiteral(@" />
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    Revisores disponibles
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <table width=""100%"" class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                        <thead>
                            <tr>
                                <th>
                                    ");
                EndContext();
                BeginContext(1071, 43, false);
#line 31 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
                               Write(Html.DisplayNameFor(model => model.NombreP));

#line default
#line hidden
                EndContext();
                BeginContext(1114, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1230, 45, false);
#line 34 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
                               Write(Html.DisplayNameFor(model => model.ApellidoP));

#line default
#line hidden
                EndContext();
                BeginContext(1275, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1391, 54, false);
#line 37 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
                               Write(Html.DisplayNameFor(model => model.CorreoElectronicoP));

#line default
#line hidden
                EndContext();
                BeginContext(1445, 241, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    Institución\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1687, 49, false);
#line 43 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
                               Write(Html.DisplayNameFor(model => model.RExtencionesP));

#line default
#line hidden
                EndContext();
                BeginContext(1736, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1852, 49, false);
#line 46 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
                               Write(Html.DisplayNameFor(model => model.RLineaTrabajo));

#line default
#line hidden
                EndContext();
                BeginContext(1901, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(2017, 42, false);
#line 49 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
                               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
                EndContext();
                BeginContext(2059, 188, true);
                WriteLiteral("\r\n                                </th>\r\n\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
                EndContext();
#line 56 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
                BeginContext(2336, 120, true);
                WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2457, 42, false);
#line 60 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.NombreP));

#line default
#line hidden
                EndContext();
                BeginContext(2499, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2627, 44, false);
#line 63 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ApellidoP));

#line default
#line hidden
                EndContext();
                BeginContext(2671, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2799, 53, false);
#line 66 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CorreoElectronicoP));

#line default
#line hidden
                EndContext();
                BeginContext(2852, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2980, 99, false);
#line 69 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.RExtencionesPNavigation.RInstitucionesNavigation.NombreInstituto));

#line default
#line hidden
                EndContext();
                BeginContext(3079, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(3207, 74, false);
#line 72 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.RExtencionesPNavigation.NombreExtencion));

#line default
#line hidden
                EndContext();
                BeginContext(3281, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(3409, 72, false);
#line 75 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.RLineaTrabajoNavigation.LineasTrabajo));

#line default
#line hidden
                EndContext();
                BeginContext(3481, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(3609, 63, false);
#line 78 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.StatusNavigation.DescEstados));

#line default
#line hidden
                EndContext();
                BeginContext(3672, 149, true);
                WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3821, "\"", 3845, 1);
#line 82 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
WriteAttributeValue("", 3829, item.IdPersonal, 3829, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 3846, "\"", 3868, 2);
                WriteAttributeValue("", 3851, ">", 3851, 1, true);
#line 82 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
WriteAttributeValue("", 3852, item.IdPersonal, 3852, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3869, 69, true);
                WriteLiteral(" />\r\n                                        &nbsp;&nbsp; <a href=\"#\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3938, "\"", 3959, 1);
#line 83 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
WriteAttributeValue("", 3943, item.IdPersonal, 3943, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3960, 149, true);
                WriteLiteral(" onclick=\"ObtenId(this)\"><i class=\"fa fa-share-square-o\"></i></a>\r\n                                    </td>\r\n                                </tr>\r\n");
                EndContext();
#line 86 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\RevisoresDisponibles.cshtml"
                            }

#line default
#line hidden
                BeginContext(4140, 155, true);
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <p>\r\n        ");
                EndContext();
                BeginContext(4295, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cb601197f914283b5663df786cfdd6a", async() => {
                    BeginContext(4339, 71, true);
                    WriteLiteral("<button type=\"button\" class=\"btn btn-default\">Volver al inicio</button>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4414, 995, true);
                WriteLiteral(@"
    </p>
    <script>
        function ObtenId(elemento) {
            //alert(elemento.id);
            var idelement = elemento.id;
            $.ajax({
                type: ""GET"",
                url: ""AsignacionRevisores/"",
                data: {
                    ""id_per"": idelement,
                    ""id_articulo"": $(""#id_ar"").val(),
                    ""comentariomemo"": $(""#come"").val()
                },
                success: function (result) {
                    elemento.style.display = 'none';
                    swal({
                        position: 'top-end',
                        type: 'success',
                        title: 'Asignación Exitosa',
                        showConfirmButton: false,
                        timer: 1500
                    });
                },
                error: function (response) {
                    alert(""no se pudo >:´v"");
                }
            });
        }
    </script>
");
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
            BeginContext(5416, 11, true);
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
