#pragma checksum "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\ServiceNurses.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f030f129c50503a97282ab524db16dddaa9d6bbe"
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
    public partial class ServiceNurses : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron1 col-9");
            __builder.AddMarkupContent(2, "<div class=\"container\"></div>\r\n   ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row mb-3");
#nullable restore
#line 4 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\ServiceNurses.razor"
       foreach (var nurse in Nurses)
      {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-4");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card flex-md-row mb-4 box-shadow h-md-300");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body d-flex flex-column align-items-start bg-h2m");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 10 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\ServiceNurses.razor"
                                nurse.NursePhoto

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", "img-thumbnail card-img-top");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                     ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-body");
            __builder.OpenElement(19, "h6");
            __builder.AddAttribute(20, "class", "card-title");
            __builder.AddContent(21, 
#nullable restore
#line 12 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\ServiceNurses.razor"
                                                nurse.NurseName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "p");
            __builder.AddAttribute(24, "class", "text-muted");
#nullable restore
#line 15 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\ServiceNurses.razor"
                            if (@nurse.NurseDocumentType == 1)
                           {
                              RTypeDoct = "Cédula Ciudadanía";
                           }
                           else if (@nurse.NurseDocumentType == 2)
                           {
                              RTypeDoct = "Cédula Extranjería";
                           }
                           else
                           {
                              RTypeDoct = "Pasaporte";
                           }

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, 
#nullable restore
#line 27 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\ServiceNurses.razor"
                            RTypeDoct

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(26, "\r\n                           ");
            __builder.OpenElement(27, "small");
            __builder.AddContent(28, 
#nullable restore
#line 28 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\ServiceNurses.razor"
                                   nurse.NurseDocument

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                           <br>");
#nullable restore
#line 31 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\ServiceNurses.razor"
                            if (@nurse.NurseSpeciality == 1)
                           {
                              RSpeciality = "Especialidad Enfermería 1";
                           }
                           else if (@nurse.NurseSpeciality == 2)
                           {
                              RSpeciality = "Especialidad Enfermería 2";
                           }
                           else if (@nurse.NurseSpeciality == 3)
                           {
                              RSpeciality = "Especialidad Enfermería 3";
                           }
                           else
                           {
                              RSpeciality = "Especialidad Enfermería 4";
                           }

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, 
#nullable restore
#line 47 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\ServiceNurses.razor"
                            RSpeciality

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\r\n                           <br>\r\n                           ");
            __builder.AddContent(32, 
#nullable restore
#line 49 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\ServiceNurses.razor"
                            nurse.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                  ");
            __builder.OpenElement(34, "div");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\ServiceNurses.razor"
                                       NurseEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\ServiceNurses.razor"
      }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\Components\ServiceNurses.razor"
       

   string RTypeDoct, RSpeciality;

   [Parameter] public List<Nurse> Nurses { get; set; }
   [Parameter] public int Id { get; set; }
   [Parameter] public string Name { get; set; }

   void NurseEdit()
   {
      Console.WriteLine($"Editando info Enfermera ");
   }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
