#pragma checksum "C:\Users\isaias spiry\Documents\MCN\MCN\Views\Autores\Perfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d922880ddea3881ece6a76faf1e57becdc37c2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autores_Perfil), @"mvc.1.0.view", @"/Views/Autores/Perfil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Autores/Perfil.cshtml", typeof(AspNetCore.Views_Autores_Perfil))]
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
#line 1 "C:\Users\isaias spiry\Documents\MCN\MCN\Views\_ViewImports.cshtml"
using MCN;

#line default
#line hidden
#line 2 "C:\Users\isaias spiry\Documents\MCN\MCN\Views\_ViewImports.cshtml"
using MCN.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d922880ddea3881ece6a76faf1e57becdc37c2b", @"/Views/Autores/Perfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e0224bf2afbd8e8ea08d54156c8c5660928715", @"/Views/_ViewImports.cshtml")]
    public class Views_Autores_Perfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MCN.Models.Autores>
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
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\isaias spiry\Documents\MCN\MCN\Views\Autores\Perfil.cshtml"
  
    ViewData["Title"] = "PerfilAutor";

#line default
#line hidden
            BeginContext(76, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(105, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54b720003d494e9e9dc67da8d622dba7", async() => {
                BeginContext(111, 88, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Perfil</title>\r\n");
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
            BeginContext(206, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(208, 2282, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0c5080b4e5948cb83028fc17b8adbb6", async() => {
                BeginContext(214, 674, true);
                WriteLiteral(@"

<div>
    <div class=""row"">
        <br />
        <h4>Materia Ciencia Y Nanociencia</h4>
        <div class=""col-lg-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    Perfil de Usuario
                </div>
                <div class=""panel-body"">
                    <dl class=""dl-horizontal"">
                        
                        
                        <!--img src=""~/images/MateriaCienciaNanociencia.png"" height=""200"" width=""400"" class=""btn btn-default btn-circle btn-xl"" id=""wrapper""/-->
                        
                        <dt>
                            ");
                EndContext();
                BeginContext(889, 43, false);
#line 32 "C:\Users\isaias spiry\Documents\MCN\MCN\Views\Autores\Perfil.cshtml"
                       Write(Html.DisplayNameFor(model => model.NombreA));

#line default
#line hidden
                EndContext();
                BeginContext(932, 91, true);
                WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
                EndContext();
                BeginContext(1024, 39, false);
#line 35 "C:\Users\isaias spiry\Documents\MCN\MCN\Views\Autores\Perfil.cshtml"
                       Write(Html.DisplayFor(model => model.NombreA));

#line default
#line hidden
                EndContext();
                BeginContext(1063, 91, true);
                WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
                EndContext();
                BeginContext(1155, 46, false);
#line 38 "C:\Users\isaias spiry\Documents\MCN\MCN\Views\Autores\Perfil.cshtml"
                       Write(Html.DisplayNameFor(model => model.ApellidosA));

#line default
#line hidden
                EndContext();
                BeginContext(1201, 91, true);
                WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
                EndContext();
                BeginContext(1293, 42, false);
#line 41 "C:\Users\isaias spiry\Documents\MCN\MCN\Views\Autores\Perfil.cshtml"
                       Write(Html.DisplayFor(model => model.ApellidosA));

#line default
#line hidden
                EndContext();
                BeginContext(1335, 91, true);
                WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
                EndContext();
                BeginContext(1427, 50, false);
#line 44 "C:\Users\isaias spiry\Documents\MCN\MCN\Views\Autores\Perfil.cshtml"
                       Write(Html.DisplayNameFor(model => model.NombreUsuarioA));

#line default
#line hidden
                EndContext();
                BeginContext(1477, 91, true);
                WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
                EndContext();
                BeginContext(1569, 46, false);
#line 47 "C:\Users\isaias spiry\Documents\MCN\MCN\Views\Autores\Perfil.cshtml"
                       Write(Html.DisplayFor(model => model.NombreUsuarioA));

#line default
#line hidden
                EndContext();
                BeginContext(1615, 91, true);
                WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
                EndContext();
                BeginContext(1707, 54, false);
#line 50 "C:\Users\isaias spiry\Documents\MCN\MCN\Views\Autores\Perfil.cshtml"
                       Write(Html.DisplayNameFor(model => model.CorreoElectronicoA));

#line default
#line hidden
                EndContext();
                BeginContext(1761, 91, true);
                WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
                EndContext();
                BeginContext(1853, 50, false);
#line 53 "C:\Users\isaias spiry\Documents\MCN\MCN\Views\Autores\Perfil.cshtml"
                       Write(Html.DisplayFor(model => model.CorreoElectronicoA));

#line default
#line hidden
                EndContext();
                BeginContext(1903, 91, true);
                WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
                EndContext();
                BeginContext(1995, 41, false);
#line 56 "C:\Users\isaias spiry\Documents\MCN\MCN\Views\Autores\Perfil.cshtml"
                       Write(Html.DisplayNameFor(model => model.TipoA));

#line default
#line hidden
                EndContext();
                BeginContext(2036, 91, true);
                WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
                EndContext();
                BeginContext(2128, 60, false);
#line 59 "C:\Users\isaias spiry\Documents\MCN\MCN\Views\Autores\Perfil.cshtml"
                       Write(Html.DisplayFor(model => model.TipoANavigation.TipoUsuarios));

#line default
#line hidden
                EndContext();
                BeginContext(2188, 205, true);
                WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n                </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    \r\n                <div>\r\n                    ");
                EndContext();
                BeginContext(2393, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79ebe319b47b42b3afe9444b283c1e0e", async() => {
                    BeginContext(2437, 16, true);
                    WriteLiteral("Volver al Inicio");
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
                BeginContext(2457, 26, true);
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
            BeginContext(2490, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MCN.Models.Autores> Html { get; private set; }
    }
}
#pragma warning restore 1591
