#pragma checksum "C:\Users\FARLAS25\Desktop\Fatima Ayala (SMIS003321)\firstApp\Views\Personal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c64169f1284a84358feb23ece42f45d4bb0963d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Index), @"mvc.1.0.view", @"/Views/Personal/Index.cshtml")]
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
#line 1 "C:\Users\FARLAS25\Desktop\Fatima Ayala (SMIS003321)\firstApp\Views\_ViewImports.cshtml"
using firstApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FARLAS25\Desktop\Fatima Ayala (SMIS003321)\firstApp\Views\_ViewImports.cshtml"
using firstApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c64169f1284a84358feb23ece42f45d4bb0963d5", @"/Views/Personal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24d16f47d817d4fcd151f0670df54f2a66570199", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Personal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<H1> PAGINA PERSONAL</H1>\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\FARLAS25\Desktop\Fatima Ayala (SMIS003321)\firstApp\Views\Personal\Index.cshtml"
Write(Html.LabelFor(c=>c.Nombre, "Nombre: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "C:\Users\FARLAS25\Desktop\Fatima Ayala (SMIS003321)\firstApp\Views\Personal\Index.cshtml"
                                   Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\FARLAS25\Desktop\Fatima Ayala (SMIS003321)\firstApp\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.Apellido, "Apellido: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\FARLAS25\Desktop\Fatima Ayala (SMIS003321)\firstApp\Views\Personal\Index.cshtml"
                                       Write(Model.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\FARLAS25\Desktop\Fatima Ayala (SMIS003321)\firstApp\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.Edad, "Edad: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "C:\Users\FARLAS25\Desktop\Fatima Ayala (SMIS003321)\firstApp\Views\Personal\Index.cshtml"
                               Write(Model.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\FARLAS25\Desktop\Fatima Ayala (SMIS003321)\firstApp\Views\Personal\Index.cshtml"
Write(Html.LabelFor(c=>c.CorreoElectronico, "CorreoElectronico: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\FARLAS25\Desktop\Fatima Ayala (SMIS003321)\firstApp\Views\Personal\Index.cshtml"
                                                         Write(Model.CorreoElectronico);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\FARLAS25\Desktop\Fatima Ayala (SMIS003321)\firstApp\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.Telefono, "Telefono: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\FARLAS25\Desktop\Fatima Ayala (SMIS003321)\firstApp\Views\Personal\Index.cshtml"
                                       Write(Model.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\FARLAS25\Desktop\Fatima Ayala (SMIS003321)\firstApp\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.Direccion, "Direccion: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\FARLAS25\Desktop\Fatima Ayala (SMIS003321)\firstApp\Views\Personal\Index.cshtml"
                                         Write(Model.Direccion);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Personal> Html { get; private set; }
    }
}
#pragma warning restore 1591
