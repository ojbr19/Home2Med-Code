#pragma checksum "F:\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\CreateFamily.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db952094e52e84760f5bd3e0a0e4f1d0ae4112ca"
// <auto-generated/>
#pragma warning disable 1591
namespace Home2Med.Client.Pages.PageEps
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eps/createfamily")]
    public partial class CreateFamily : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<nav class=\"navbar navbar-expand-sm navbar-h2m bg-prima mb-3\"><div class=\"container\"><a class=\"navbar-brand\" href=\"#\">E P S - Creación Familiar del Paciente</a></div></nav>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center align-items-center");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "jumbotron col-8");
            __builder.AddMarkupContent(5, "<div class=\"form-group ml-4 mb-2 col-11\"><p class=\"mb-0\"><strong>Nombresssssss y Apellidos</strong></p>\r\n         <input type=\"text\" class=\"form-control\" id=\"patient_name\" placeholder=\"Ingresar Nombres y Apellidos\"></div>\r\n      ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group ml-5 mb-2 col-5");
            __builder.AddMarkupContent(10, "<p class=\"mb-0\"><strong>Tipo Documento</strong></p>\r\n            ");
            __builder.OpenElement(11, "select");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", "0");
            __builder.AddContent(15, "Selecciona un Tipo Documento");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n               ");
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", "1");
            __builder.AddMarkupContent(19, "Cédula de Ciudadanía");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n               ");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", "2");
            __builder.AddMarkupContent(23, "Cédula de Extranjería");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n         ");
            __builder.AddMarkupContent(25, "<div class=\"form-group ml-1 mb-2 col-5\"><p class=\"mb-0\"><strong>Número de Documento</strong></p>\r\n            <input type=\"text\" class=\"form-control\" id=\"patient_name\" placeholder=\"Ingresar Número de Documento\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n      ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "form-group ml-5 mb-2 col-5");
            __builder.AddMarkupContent(31, "<p class=\"mb-0\"><strong>Genero</strong></p>\r\n            ");
            __builder.OpenElement(32, "select");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", "0");
            __builder.AddContent(36, "Selecciona Genero");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n               ");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", "1");
            __builder.AddContent(40, "Femenino");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n               ");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", "0");
            __builder.AddContent(44, "Masculino");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n         ");
            __builder.AddMarkupContent(46, "<div class=\"form-group ml-1 mb-2 col-5\"><p class=\"mb-0\"><strong>Número de Contacto</strong></p>\r\n            <input type=\"text\" class=\"form-control\" id=\"patient_name\" placeholder=\"Ingresar Número de Contacto\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n      ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group ml-5 mb-2 col-5");
            __builder.AddMarkupContent(52, "<p class=\"mb-0\"><strong>Relación con el Paciente</strong></p>\r\n            ");
            __builder.OpenElement(53, "select");
            __builder.AddAttribute(54, "class", "form-control");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", "0");
            __builder.AddMarkupContent(57, "Selecciona una Opción");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n               ");
            __builder.OpenElement(59, "option");
            __builder.AddAttribute(60, "value", "1");
            __builder.AddContent(61, "Madre");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n               ");
            __builder.OpenElement(63, "option");
            __builder.AddAttribute(64, "value", "2");
            __builder.AddContent(65, "Padre");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n               ");
            __builder.OpenElement(67, "option");
            __builder.AddAttribute(68, "value", "3");
            __builder.AddContent(69, "Hijo");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n               ");
            __builder.OpenElement(71, "option");
            __builder.AddAttribute(72, "value", "4");
            __builder.AddContent(73, "Hermano");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n               ");
            __builder.OpenElement(75, "option");
            __builder.AddAttribute(76, "value", "5");
            __builder.AddContent(77, "Abuelo");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n               ");
            __builder.OpenElement(79, "option");
            __builder.AddAttribute(80, "value", "6");
            __builder.AddContent(81, "Tio");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n               ");
            __builder.OpenElement(83, "option");
            __builder.AddAttribute(84, "value", "7");
            __builder.AddContent(85, "Amigo");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n               ");
            __builder.OpenElement(87, "option");
            __builder.AddAttribute(88, "value", "8");
            __builder.AddContent(89, "Vecino");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n               ");
            __builder.OpenElement(91, "option");
            __builder.AddAttribute(92, "value", "9");
            __builder.AddContent(93, "Enfermera");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n         ");
            __builder.AddMarkupContent(95, "<div class=\"form-group ml-1 mb-2 col-5\"><p class=\"mb-0\"><strong>Correo Electrónico</strong></p>\r\n            <input type=\"email\" class=\"form-control\" id=\"patient_name\" placeholder=\"Ingresa Correo Electrónico\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n      ");
            __builder.AddMarkupContent(97, @"<div class=""row""><div class=""form-group ml-5 mb-2 col-5""><p class=""mb-0""><strong>Documento del Paciente</strong></p>
            <input type=""text"" class=""form-control"" id=""patient_name"" placeholder=""Ingresar Documento del Paciente""></div></div>


      ");
            __builder.AddMarkupContent(98, "<div><button type=\"button\" class=\"btn btn-success mt-4 mb-2 ml-5\">Guardar</button>\r\n         <button type=\"button\" class=\"btn btn-danger mt-4 mb-2 ml-3\">Limpiar campos</button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
