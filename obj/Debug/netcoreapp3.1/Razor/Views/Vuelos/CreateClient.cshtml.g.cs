#pragma checksum "C:\Users\jadri\Source\Repos\JosueDAH012\ProyectoServiciosWeb\Views\Vuelos\CreateClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6936cd79dbeab0b675cbf6e5529f146fd9b5b975"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vuelos_CreateClient), @"mvc.1.0.view", @"/Views/Vuelos/CreateClient.cshtml")]
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
#line 1 "C:\Users\jadri\Source\Repos\JosueDAH012\ProyectoServiciosWeb\Views\_ViewImports.cshtml"
using V_VuelosServiciosWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jadri\Source\Repos\JosueDAH012\ProyectoServiciosWeb\Views\_ViewImports.cshtml"
using V_VuelosServiciosWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6936cd79dbeab0b675cbf6e5529f146fd9b5b975", @"/Views/Vuelos/CreateClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b822b0e7e61e7f1ae2dedb5ad18201a5dbad494d", @"/Views/_ViewImports.cshtml")]
    public class Views_Vuelos_CreateClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jadri\Source\Repos\JosueDAH012\ProyectoServiciosWeb\Views\Vuelos\CreateClient.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""containerNew"">


    <label for=""User""><b>NAME</b></label>
    <input type=""text"" placeholder=""Enter Name"" name=""Name"" required>

    <label for=""User""><b>FIRST LAST NAME</b></label>
    <input type=""text"" placeholder=""Enter Last Name"" name=""lastname1"" required>

    <label for=""User""><b>SECOND LAST NAME</b></label>
    <input type=""text"" placeholder=""Enter Last Name"" name=""lastname2"" required>

    <label for=""User""><b>USERNAME</b></label>
    <input type=""text"" placeholder=""Enter Username"" name=""User"" required>

    <label for=""Pass""><b>PASSWORD</b></label>
    <input type=""password"" placeholder=""Enter Password"" name=""Pass"" required>

    <label for=""Email""><b>EMAIL</b></label>
    <input type=""text"" placeholder=""Enter Email"" name=""Email"" required>

    <button class=""button btn"" type=""submit"">Ingresar</button>

</div>");
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
