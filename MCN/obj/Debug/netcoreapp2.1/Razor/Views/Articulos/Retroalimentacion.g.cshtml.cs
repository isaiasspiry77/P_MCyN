#pragma checksum "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3569f72b8e8e42eabd4fb25ec0460eb406b34e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articulos_Retroalimentacion), @"mvc.1.0.view", @"/Views/Articulos/Retroalimentacion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Articulos/Retroalimentacion.cshtml", typeof(AspNetCore.Views_Articulos_Retroalimentacion))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3569f72b8e8e42eabd4fb25ec0460eb406b34e8", @"/Views/Articulos/Retroalimentacion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e0224bf2afbd8e8ea08d54156c8c5660928715", @"/Views/_ViewImports.cshtml")]
    public class Views_Articulos_Retroalimentacion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MCN.Models.DetalleArticulos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("esta"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Retroalimentacion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Listado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
  
    ViewData["Title"] = "RetroalimentarArticulos";
    ViewData["Tipo"] = ViewData["tipo"];

#line default
#line hidden
            BeginContext(139, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(168, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f50f10f76b044fae8a48c5fe80b8b6f4", async() => {
                BeginContext(174, 99, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Retroalimentacion</title>\r\n");
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
            BeginContext(282, 3980, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "495df15ed486415abbadc1642e9c3dac", async() => {
                BeginContext(288, 150, true);
                WriteLiteral("\r\n\r\n\r\n    <div class=\"row\">\r\n        <h4>DetalleArticulos</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(439, 71, false);
#line 23 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
           Write(Html.DisplayNameFor(model => model.IdArticuloNavigation.TituloArticulo));

#line default
#line hidden
                EndContext();
                BeginContext(510, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(566, 67, false);
#line 26 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
           Write(Html.DisplayFor(model => model.IdArticuloNavigation.TituloArticulo));

#line default
#line hidden
                EndContext();
                BeginContext(633, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(689, 63, false);
#line 29 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
           Write(Html.DisplayNameFor(model => model.IdArticuloNavigation.RAutor));

#line default
#line hidden
                EndContext();
                BeginContext(752, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(808, 77, false);
#line 32 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
           Write(Html.DisplayFor(model => model.IdArticuloNavigation.RAutorNavigation.NombreA));

#line default
#line hidden
                EndContext();
                BeginContext(885, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(904, 80, false);
#line 33 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
           Write(Html.DisplayFor(model => model.IdArticuloNavigation.RAutorNavigation.ApellidosA));

#line default
#line hidden
                EndContext();
                BeginContext(984, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1040, 74, false);
#line 36 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
           Write(Html.DisplayNameFor(model => model.IdArticuloNavigation.FechaPublicacionA));

#line default
#line hidden
                EndContext();
                BeginContext(1114, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1170, 70, false);
#line 39 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
           Write(Html.DisplayFor(model => model.IdArticuloNavigation.FechaPublicacionA));

#line default
#line hidden
                EndContext();
                BeginContext(1240, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1296, 73, false);
#line 42 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
           Write(Html.DisplayNameFor(model => model.IdArticuloNavigation.ComentariosAutor));

#line default
#line hidden
                EndContext();
                BeginContext(1369, 74, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                <p align=\"justify\">");
                EndContext();
                BeginContext(1444, 69, false);
#line 45 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
                              Write(Html.DisplayFor(model => model.IdArticuloNavigation.ComentariosAutor));

#line default
#line hidden
                EndContext();
                BeginContext(1513, 59, true);
                WriteLiteral("</p>\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1573, 46, false);
#line 48 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
           Write(Html.DisplayNameFor(model => model.IdPersonal));

#line default
#line hidden
                EndContext();
                BeginContext(1619, 21, true);
                WriteLiteral("\r\n            </dt>\r\n");
                EndContext();
#line 50 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
             if (Html.DisplayFor(model => model.IdPersonal) != null)
            {

#line default
#line hidden
                BeginContext(1725, 86, true);
                WriteLiteral("                <dd>\r\n                    Revisor no Asignado\r\n                </dd>\r\n");
                EndContext();
#line 55 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(1859, 42, true);
                WriteLiteral("                <dd>\r\n                    ");
                EndContext();
                BeginContext(1902, 42, false);
#line 59 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
               Write(Html.DisplayFor(model => model.IdPersonal));

#line default
#line hidden
                EndContext();
                BeginContext(1944, 25, true);
                WriteLiteral("\r\n                </dd>\r\n");
                EndContext();
#line 61 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
            }

#line default
#line hidden
                BeginContext(1984, 61, true);
                WriteLiteral("        </dl>\r\n\r\n        <div class=\"col-md-4\">\r\n            ");
                EndContext();
                BeginContext(2045, 2098, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b4a081592c14a97b941532049018fa2", async() => {
                    BeginContext(2082, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(2100, 66, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d327506b0fe4b91b39dffa960fc3c11", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 66 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2166, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(2184, 46, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0c3cc21fd1b8468fa64c957e8322e8ca", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 67 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdDetalleArt);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2230, 1191, true);
                    WriteLiteral(@"
                <!--div class=""form-group"">
        <label asp-for=""IdPersonal"" class=""control-label""></label>
        <select asp-for=""IdPersonal"" class=""form-control"" asp-items=""ViewBag.IdPersonal""></select>
        <span asp-validation-for=""IdPersonal"" class=""text-danger""></span>
    </div>
    <div class=""form-group"">
        <label asp-for=""FechaRevision"" class=""control-label""></label>
        <input asp-for=""FechaRevision"" class=""form-control"" />
        <span asp-validation-for=""FechaRevision"" class=""text-danger""></span>
    </div>
    <div class=""form-group"">
        <label asp-for=""ComentariosRetroaliment"" class=""control-label""></label>
        <input asp-for=""ComentariosRetroaliment"" class=""form-control"" />
        <span asp-validation-for=""ComentariosRetroaliment"" class=""text-danger""></span>
    </div>
    <div class=""form-group"">
        <label asp-for=""IdArticulo"" class=""control-label""></label>
        <select asp-for=""IdArticulo"" class=""form-control"" asp-items=""ViewBag.IdArtic");
                    WriteLiteral("ulo\"></select>\r\n        <span asp-validation-for=\"IdArticulo\" class=\"text-danger\"></span>\r\n    </div-->\r\n                <div class=\"form-group\">\r\n                    ");
                    EndContext();
                    BeginContext(3421, 54, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "425a3c4cacb54b5d8d46d52f8af07308", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 89 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Status);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3475, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(3497, 93, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ed6b5238e3947c3b893c088f05c7b23", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 90 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Status);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 90 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Estados;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3590, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(3612, 61, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f02107f342084f408e118ec4daba9ec8", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 91 "C:\Users\isaias spiry\source\repos\P_MCyN\MCN\Views\Articulos\Retroalimentacion.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Status);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3673, 463, true);
                    WriteLiteral(@"
                </div>
                <div class=""form-group"">
                    <label class=""control-label"">Comentario Editor</label>
                    <textarea class=""form-control"" rows=""5"" id=""textareaedi""></textarea>
                </div>

                <div class=""form-group"">
                    <input type=""submit"" id=""botonretro"" value=""Asignar Revisor"" name=""btnretro"" class=""btn btn-default"" />
                </div>
            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4143, 55, true);
                WriteLiteral("\r\n        </div>\r\n        \r\n\r\n    </div>\r\n\r\n<div>\r\n    ");
                EndContext();
                BeginContext(4198, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7832d223df74c46846a737d77e7de09", async() => {
                    BeginContext(4222, 17, true);
                    WriteLiteral("Volver al Listado");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4243, 12, true);
                WriteLiteral("\r\n</div>\r\n\r\n");
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
            BeginContext(4262, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MCN.Models.DetalleArticulos> Html { get; private set; }
    }
}
#pragma warning restore 1591
