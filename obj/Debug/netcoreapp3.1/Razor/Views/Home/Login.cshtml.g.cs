#pragma checksum "C:\Users\jadri\Source\Repos\JosueDAH012\ProyectoServiciosWeb\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5019f25062ba2fd4e72517c98a2099086b39f3f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5019f25062ba2fd4e72517c98a2099086b39f3f0", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b822b0e7e61e7f1ae2dedb5ad18201a5dbad494d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jadri\Source\Repos\JosueDAH012\ProyectoServiciosWeb\Views\Home\Login.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    <div class=""containerNew"">
        <label for=""uname""><b>USERNAME</b></label>
        <input type=""text"" placeholder=""Enter Username"" name=""uname"" required>

        <label for=""psw""><b>PASSWORD</b></label>
        <input type=""password"" placeholder=""Enter Password"" name=""psw"" required>

        <button class=""button btn"" type=""submit"">Login</button>
        <label>
            <input type=""checkbox"" checked=""checked"" name=""remember""> Remember me
        </label>
        <div>
            <span class=""psw"">Forgot <a");
            BeginWriteAttribute("href", " href=\"", 597, "\"", 642, 1);
#nullable restore
#line 19 "C:\Users\jadri\Source\Repos\JosueDAH012\ProyectoServiciosWeb\Views\Home\Login.cshtml"
WriteAttributeValue("", 604, Url.Action("ForgotPassword","vuelos"), 604, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">password?</a></span>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
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