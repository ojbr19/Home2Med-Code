#pragma checksum "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a9a321d87fde33f936c8aa96edbd8408cdb81f7"
// <auto-generated/>
#pragma warning disable 1591
namespace Home2Med.Client.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client.Services;

#line default
#line hidden
#nullable disable
    public partial class FormDoctor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<nav class=\"navbar navbar-expand-sm navbar-h2m bg-prima mb-3\"><div class=\"container\"><a class=\"navbar-brand\" href=\"#\"><strong>E P S - Creación Médico</strong></a></div></nav>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center align-items-center");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "jumbotron1 col-8");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor"
                       Doctor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor"
                                              OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n\r\n         ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group ml-4 mb-2 col-11");
                __builder2.AddMarkupContent(13, "<p class=\"mb-0\"><strong>Nombres y Apellidos</strong></p>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "placeholder", "Ingresar Nombres y Apellidos");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor"
                                                          Doctor.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Doctor.Name = __value, Doctor.Name))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Doctor.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __Blazor.Home2Med.Client.Pages.Components.FormDoctor.TypeInference.CreateValidationMessage_0(__builder2, 21, 22, 
#nullable restore
#line 18 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor"
                                      ()=>Doctor.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n         ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "row");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group ml-5 mb-2 col-5");
                __builder2.AddMarkupContent(28, "<p class=\"mb-0\"><strong>Tipo Documento</strong></p>\r\n               ");
                __builder2.OpenElement(29, "select");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "name", "select");
                __builder2.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor"
                                                                  Doctor.DocumentType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Doctor.DocumentType = __value, Doctor.DocumentType));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(34, "option");
                __builder2.AddAttribute(35, "value", "0");
                __builder2.AddAttribute(36, "selected");
                __builder2.AddMarkupContent(37, "Seleccione una Opción");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                  ");
                __builder2.OpenElement(39, "option");
                __builder2.AddAttribute(40, "value", "1");
                __builder2.AddMarkupContent(41, "Cédula de Ciudadanía");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                  ");
                __builder2.OpenElement(43, "option");
                __builder2.AddAttribute(44, "value", "2");
                __builder2.AddMarkupContent(45, "Cédula de Extranjería");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                  ");
                __builder2.OpenElement(47, "option");
                __builder2.AddAttribute(48, "value", "3");
                __builder2.AddContent(49, "Pasaporte");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n               ");
                __Blazor.Home2Med.Client.Pages.Components.FormDoctor.TypeInference.CreateValidationMessage_1(__builder2, 51, 52, 
#nullable restore
#line 30 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor"
                                         ()=>Doctor.DocumentType

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n\r\n            ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group ml-1 mb-2 col-5");
                __builder2.AddMarkupContent(56, "<p class=\"mb-0\"><strong>Número de Documento</strong></p>\r\n               ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(57);
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "placeholder", "Ingresar Número de Documento");
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor"
                                                             Doctor.Document

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Doctor.Document = __value, Doctor.Document))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Doctor.Document));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n               ");
                __Blazor.Home2Med.Client.Pages.Components.FormDoctor.TypeInference.CreateValidationMessage_2(__builder2, 64, 65, 
#nullable restore
#line 36 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor"
                                         ()=>Doctor.Document

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n\r\n         ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "row");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group ml-5 mb-2 col-5");
                __builder2.AddMarkupContent(71, "<p class=\"mb-0\"><strong>Genero</strong></p>\r\n               ");
                __builder2.OpenElement(72, "select");
                __builder2.AddAttribute(73, "class", "form-control");
                __builder2.AddAttribute(74, "name", "select");
                __builder2.AddAttribute(75, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor"
                                                                  Doctor.Gender

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Doctor.Gender = __value, Doctor.Gender));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(77, "option");
                __builder2.AddAttribute(78, "value", "0");
                __builder2.AddAttribute(79, "selected");
                __builder2.AddMarkupContent(80, "Seleccione una Opción");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                  ");
                __builder2.OpenElement(82, "option");
                __builder2.AddAttribute(83, "value", "1");
                __builder2.AddContent(84, "Femenino");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                  ");
                __builder2.OpenElement(86, "option");
                __builder2.AddAttribute(87, "value", "2");
                __builder2.AddContent(88, "Masculino");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n               ");
                __Blazor.Home2Med.Client.Pages.Components.FormDoctor.TypeInference.CreateValidationMessage_3(__builder2, 90, 91, 
#nullable restore
#line 48 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor"
                                         ()=>Doctor.Gender

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n            ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-group ml-1 mb-2 col-5");
                __builder2.AddMarkupContent(95, "<p class=\"mb-0\"><strong>Número de Contacto</strong></p>\r\n               ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(96);
                __builder2.AddAttribute(97, "class", "form-control");
                __builder2.AddAttribute(98, "placeholder", "Ingresar Número de Contacto");
                __builder2.AddAttribute(99, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor"
                                                             Doctor.Phone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(100, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Doctor.Phone = __value, Doctor.Phone))));
                __builder2.AddAttribute(101, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Doctor.Phone));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(102, "\r\n               ");
                __Blazor.Home2Med.Client.Pages.Components.FormDoctor.TypeInference.CreateValidationMessage_4(__builder2, 103, 104, 
#nullable restore
#line 53 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor"
                                         ()=>Doctor.Phone

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n\r\n         ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "row");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "form-group ml-5 mb-2 col-5");
                __builder2.AddMarkupContent(110, "<p class=\"mb-0\"><strong>Especialidad</strong></p>\r\n               ");
                __builder2.OpenElement(111, "select");
                __builder2.AddAttribute(112, "class", "form-control");
                __builder2.AddAttribute(113, "name", "selected");
                __builder2.AddAttribute(114, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor"
                                                                   Doctor.Speciality

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(115, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Doctor.Speciality = __value, Doctor.Speciality));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(116, "option");
                __builder2.AddAttribute(117, "value", "0");
                __builder2.AddAttribute(118, "selected");
                __builder2.AddMarkupContent(119, "Seleccione una Opción");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n                  ");
                __builder2.OpenElement(121, "option");
                __builder2.AddAttribute(122, "value", "1");
                __builder2.AddMarkupContent(123, "Especialidad Médica 1");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n                  ");
                __builder2.OpenElement(125, "option");
                __builder2.AddAttribute(126, "value", "2");
                __builder2.AddMarkupContent(127, "Especialidad Médica 2");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n                  ");
                __builder2.OpenElement(129, "option");
                __builder2.AddAttribute(130, "value", "3");
                __builder2.AddMarkupContent(131, "Especialidad Médica 3");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n                  ");
                __builder2.OpenElement(133, "option");
                __builder2.AddAttribute(134, "value", "4");
                __builder2.AddMarkupContent(135, "Especialidad Médica 4");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n               ");
                __Blazor.Home2Med.Client.Pages.Components.FormDoctor.TypeInference.CreateValidationMessage_5(__builder2, 137, 138, 
#nullable restore
#line 67 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor"
                                         ()=>Doctor.Speciality

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n            ");
                __builder2.OpenElement(140, "div");
                __builder2.AddAttribute(141, "class", "form-group ml-5 mt-4 mb-3");
                __builder2.OpenElement(142, "input");
                __builder2.AddAttribute(143, "type", "checkbox");
                __builder2.AddAttribute(144, "class", "form-check-input");
                __builder2.AddAttribute(145, "id", "estado");
                __builder2.AddAttribute(146, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor"
                                                                                  Doctor.Status

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(147, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Doctor.Status = __value, Doctor.Status));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n               ");
                __builder2.AddMarkupContent(149, "<label class=\"form-check-label\" for=\"estado\">Activo</label>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(150, "\r\n\r\n         <div class=\"form-group\"></div>\r\n\r\n         ");
                __builder2.AddMarkupContent(151, "<button class=\"btn btn-success mt-4 mb-2 ml-5\">Guardar</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\FormDoctor.razor"
       



   public class ListDocumentType
   {
      public int IdListDocument { get; set; }
      public string NameTypeDocument { get; set; }
   }

   string imageURL;

   [Parameter] public Doctor Doctor { get; set; }
   [Parameter] public EventCallback OnValidSubmit { get; set; }

   protected override void OnInitialized()
   {
      if (!string.IsNullOrEmpty(Doctor.Photo))
      {
         imageURL = Doctor.Photo;
         Doctor.Photo = null;
      }
   }

   private void ImageSelected(string imageB64)
   {
      Doctor.Photo = imageB64;
      imageURL = null;
   }

   public List<ListDocumentType> ListDocument = new List<ListDocumentType>();

   protected override Task OnInitializedAsync()
   {
      ListDocumentType cero = new ListDocumentType();
      cero.IdListDocument = 0;
      cero.NameTypeDocument = "Seleccione una Opción";
      ListDocumentType uno = new ListDocumentType();
      uno.IdListDocument = 1;
      uno.NameTypeDocument = "Cédula de Ciudadanía";
      ListDocumentType dos = new ListDocumentType();
      dos.IdListDocument = 2;
      dos.NameTypeDocument = "Cédula de ExtranjNría";
      ListDocumentType tres = new ListDocumentType();
      tres.IdListDocument = 3;
      tres.NameTypeDocument = "Pasaporte";

      ListDocument.Add(cero);
      ListDocument.Add(uno);
      ListDocument.Add(dos);
      ListDocument.Add(tres);

      return base.OnInitializedAsync();
   }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Home2Med.Client.Pages.Components.FormDoctor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
