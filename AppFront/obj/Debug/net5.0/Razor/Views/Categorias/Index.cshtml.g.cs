#pragma checksum "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a89a8e2934457b4196ab11c2d401d5b87954c895"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorias_Index), @"mvc.1.0.view", @"/Views/Categorias/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a89a8e2934457b4196ab11c2d401d5b87954c895", @"/Views/Categorias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"499d601515b3cfda8ff5ded057417a4f0556306d", @"/Views/_ViewImports.cshtml")]
    public class Views_Categorias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppFront.Models.Categoria>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<header class=""bg-dark"">
    <nav class=""navbar navbar-expand-lg navbar navbar-dark bg-dark"">
        <div class=""container-fluid bg-dark"">
            <a class=""navbar-brand"" href=""#"">
                <span class=""glyphicon glyphicon-briefcase""></span>¡Empleos Ya!|
            </a>
            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarNavAltMarkup"" aria-controls=""navbarNavAltMarkup"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarNavAltMarkup"">
                <div class=""navbar-nav"">
                    <a class=""nav-link active"" aria-current=""page"" href=""#"">Home</a>
                    <a class=""nav-link active"" href=""#"">Contactos</a> |
                    <a class=""nav-link active""");
            BeginWriteAttribute("href", " href=\"", 1023, "\"", 1061, 1);
#nullable restore
#line 20 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Index.cshtml"
WriteAttributeValue("", 1030, Url.Action("Index", "Empleos"), 1030, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Empleos</a>\n                    <a class=\"nav-link active\"");
            BeginWriteAttribute("href", " href=\"", 1121, "\"", 1162, 1);
#nullable restore
#line 21 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Index.cshtml"
WriteAttributeValue("", 1128, Url.Action("Index", "Categorias"), 1128, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Categorias</a>\n                </div>\n            </div>\n        </div>\n    </nav>\n</header>\n\n<h1>Categorias</h1>\n<a class=\"btn btn-success text-white btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 1322, "\"", 1364, 1);
#nullable restore
#line 29 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Index.cshtml"
WriteAttributeValue("", 1329, Url.Action("Create", "Categorias"), 1329, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><span class=""glyphicon glyphicon-plus""> Agregar categoria</span></a>


<input id=""txtBusqueda"" type=""text"" class=""form-control"" placeholder=""Filtrar"" onkeyup=""Buscar();"" />
<hr />
<br />
<table class=""table"" id=""tblPersonas"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 39 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            </th>\n            <th>\n                ");
#nullable restore
#line 43 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreCategoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 49 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1981, "\"", 2046, 1);
#nullable restore
#line 53 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Index.cshtml"
WriteAttributeValue("", 1988, Url.Action("Details", "Categorias", new { id = item.ID }), 1988, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        ");
#nullable restore
#line 54 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </a>\n                </td>\n                <td>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2202, "\"", 2267, 1);
#nullable restore
#line 58 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Index.cshtml"
WriteAttributeValue("", 2209, Url.Action("Details", "Categorias", new { id = item.ID }), 2209, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n\n                        ");
#nullable restore
#line 60 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NombreCategoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </a>\n                </td>\n                <td>\n                    <a class=\"btn btn-warning text-white btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 2479, "\"", 2541, 1);
#nullable restore
#line 64 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Index.cshtml"
WriteAttributeValue("", 2486, Url.Action("Edit", "Categorias", new { id = item.ID }), 2486, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Editar<span class=\"glyphicon glyphicon-edit\"></span></a>\n                    <a class=\"btn btn-danger text-white btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 2664, "\"", 2728, 1);
#nullable restore
#line 65 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Index.cshtml"
WriteAttributeValue("", 2671, Url.Action("Delete", "Categorias", new { id = item.ID }), 2671, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Eliminar<span class=\"glyphicon glyphicon-remove\"></span></a>\n                </td>\n            </tr>\n");
#nullable restore
#line 68 "C:\Users\josti\OneDrive\Documentos\nuevo cuastrimestre\Programacion 3\Nueva carpeta\G5-Prog-3-master\AppFront\Views\Categorias\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<script type=""text/javascript"">
    function Buscar() {
        var tabla = document.getElementById('tblPersonas');
        var busqueda = document.getElementById('txtBusqueda').value.toLowerCase();
        var cellsOfRow = """";
        var found = false;
        var compareWith = """";
        for (var i = 1; i < tabla.rows.length; i++) {
            cellsOfRow = tabla.rows[i].getElementsByTagName('td');
            found = false;
            for (var j = 0; j < cellsOfRow.length && !found; j++) {
                compareWith = cellsOfRow[j].innerHTML.toLowerCase(); if (busqueda.length == 0 || (compareWith.indexOf(busqueda) > -1)) {
                    found = true;
                }
            }
            if (found) {
                tabla.rows[i].style.display = '';
            } else {
                tabla.rows[i].style.display = 'none';
            }
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppFront.Models.Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
