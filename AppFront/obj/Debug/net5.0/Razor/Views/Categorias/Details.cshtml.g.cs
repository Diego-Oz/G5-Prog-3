#pragma checksum "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abe094b64be9cd6d1825d44b6a37403b44a67b9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorias_Details), @"mvc.1.0.view", @"/Views/Categorias/Details.cshtml")]
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
#line 1 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\_ViewImports.cshtml"
using AppFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\_ViewImports.cshtml"
using AppFront.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abe094b64be9cd6d1825d44b6a37403b44a67b9b", @"/Views/Categorias/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"499d601515b3cfda8ff5ded057417a4f0556306d", @"/Views/_ViewImports.cshtml")]
    public class Views_Categorias_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppFront.Models.Categoria>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Categoria</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 15 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 18 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Details.cshtml"
       Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 21 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NombreCategoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 24 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Details.cshtml"
       Write(Html.DisplayFor(model => model.NombreCategoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    <a  class=\"btn btn-secondary\" -action=\"Index\">Regresar</a>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppFront.Models.Categoria> Html { get; private set; }
    }
}
#pragma warning restore 1591
