#pragma checksum "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c76315051436dd2bc5645f39f026e4ff6b257ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleos_Index), @"mvc.1.0.view", @"/Views/Empleos/Index.cshtml")]
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
#line 1 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\_ViewImports.cshtml"
using AppFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\_ViewImports.cshtml"
using AppFront.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c76315051436dd2bc5645f39f026e4ff6b257ff", @"/Views/Empleos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3683f5dae7471010969fd85a6c3f0f2bcb0ead2", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppFront.Models.Empleo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
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
                    <a class=""nav-link active""");
            BeginWriteAttribute("href", " href=\"", 960, "\"", 995, 1);
#nullable restore
#line 17 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
WriteAttributeValue("", 967, Url.Action("Login", "Home"), 967, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Categorias</a>\r\n                    <a class=\"nav-link active\"");
            BeginWriteAttribute("href", " href=\"", 1059, "\"", 1094, 1);
#nullable restore
#line 18 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
WriteAttributeValue("", 1066, Url.Action("Login", "Home"), 1066, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Iniciar Sesion</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n</header>\r\n<br />\r\n<br />\r\n<h1>Empleos</h1>\r\n<a class=\"btn btn-success text-white btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 1277, "\"", 1316, 1);
#nullable restore
#line 27 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
WriteAttributeValue("", 1284, Url.Action("Create", "Empleos"), 1284, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-plus\"> Postularse</span></a>\r\n<hr />\r\n");
            WriteLiteral(@"
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.23/css/jquery.dataTables.css"">
<script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.10.23/js/jquery.dataTables.js""></script>

<table class=""table"" id=""myTable"">
    <thead>

        <tr class=""table-info"">
            <th class=""d-print-none"">
                ");
#nullable restore
#line 41 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Compañia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Posicion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ubicacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 55 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 2309, "\"", 2371, 1);
#nullable restore
#line 60 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
WriteAttributeValue("", 2316, Url.Action("Details", "Empleos", new { id = item.Id }), 2316, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 61 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n    </td>\r\n    <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 2472, "\"", 2534, 1);
#nullable restore
#line 65 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
WriteAttributeValue("", 2479, Url.Action("Details", "Empleos", new { id = item.Id }), 2479, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 66 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Compañia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n    </td>\r\n    <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 2641, "\"", 2703, 1);
#nullable restore
#line 70 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
WriteAttributeValue("", 2648, Url.Action("Details", "Empleos", new { id = item.Id }), 2648, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 71 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Posicion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n    </td>\r\n    <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 2810, "\"", 2872, 1);
#nullable restore
#line 75 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
WriteAttributeValue("", 2817, Url.Action("Details", "Empleos", new { id = item.Id }), 2817, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 76 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Ubicacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 80 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#myTable\').DataTable();\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppFront.Models.Empleo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
