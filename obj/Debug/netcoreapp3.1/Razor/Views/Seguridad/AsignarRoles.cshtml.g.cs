#pragma checksum "F:\Users\jucal\Documents\GitHub\ProyectoServiciosWeb\Views\Seguridad\AsignarRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b456a06bdfcf8c95929424bc837fc3a715cf6cde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seguridad_AsignarRoles), @"mvc.1.0.view", @"/Views/Seguridad/AsignarRoles.cshtml")]
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
#line 1 "F:\Users\jucal\Documents\GitHub\ProyectoServiciosWeb\Views\_ViewImports.cshtml"
using V_VuelosServiciosWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Users\jucal\Documents\GitHub\ProyectoServiciosWeb\Views\_ViewImports.cshtml"
using V_VuelosServiciosWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b456a06bdfcf8c95929424bc837fc3a715cf6cde", @"/Views/Seguridad/AsignarRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b822b0e7e61e7f1ae2dedb5ad18201a5dbad494d", @"/Views/_ViewImports.cshtml")]
    public class Views_Seguridad_AsignarRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\Users\jucal\Documents\GitHub\ProyectoServiciosWeb\Views\Seguridad\AsignarRoles.cshtml"
  
    ViewData["Title"] = "AsignarRoles";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-10 col-md-10 col-lg-8 mx-auto"">
            <div class=""card card-signin my-5"">
                <div class=""card-body"">
                    <h1 class=""card-title text-center"">Lista de usuarios</h1>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b456a06bdfcf8c95929424bc837fc3a715cf6cde3845", async() => {
                WriteLiteral(@"
                        <div class=""list-group"">
                            <a href=""#"" class=""list-group-item list-group-item-action"">Usuario</a>
                            <a href=""#"" class=""list-group-item list-group-item-action"">Usuario</a>
                            <a href=""#"" class=""list-group-item list-group-item-action"">Usuario</a>
                            <a href=""#"" class=""list-group-item list-group-item-action"">Usuario</a>
                            <a href=""#"" class=""list-group-item list-group-item-action"">Usuario</a>
                        </div>
                        <br />
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 1096, "\"", 1104, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""Administrador"">
                            <label class=""form-check-label"" for=""Administrador"">
                                Administrador
                            </label>
                        </div><div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 1425, "\"", 1433, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""Seguridad"">
                            <label class=""form-check-label"" for=""Seguridad"">
                                Seguridad
                            </label>
                        </div><div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 1742, "\"", 1750, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""Mantenimiento"">
                            <label class=""form-check-label"" for=""Mantenimiento"">
                                Mantenimiento
                            </label>
                        </div>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 2097, "\"", 2105, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""Consultas"" checked>
                            <label class=""form-check-label"" for=""Consultas"">
                                Consultas
                            </label>
                        </div>
                        <br />
                        <div class=""form-group row"">
                            <div class=""col-sm-10"">
                                <button type=""submit"" class=""btn btn-primary"">Actualizar Roles</button>
                                <hr class=""my-4"">
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
