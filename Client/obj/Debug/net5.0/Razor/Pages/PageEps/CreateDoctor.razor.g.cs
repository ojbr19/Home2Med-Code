#pragma checksum "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\CreateDoctor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf668a1d5bbe8a48e10c4bd704930bb9e5346b21"
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
#nullable restore
#line 2 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\CreateDoctor.razor"
using Home2Med.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eps/createdoctor")]
    public partial class CreateDoctor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Home2Med.Client.Pages.Components.FormDoctor>(0);
            __builder.AddAttribute(1, "Doctor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Home2Med.Shared.Entity.Doctor>(
#nullable restore
#line 4 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\CreateDoctor.razor"
                      Doctor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 4 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\CreateDoctor.razor"
                                             Create

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\CreateDoctor.razor"
       
   private Doctor Doctor = new Doctor();
   void Create()
   {
      Console.WriteLine($"Nombre {Doctor.Name}");
      Console.WriteLine($"Tipo de Documento {Doctor.DocumentType}");
      Console.WriteLine($"Documento {Doctor.Document}");
      Console.WriteLine($"Genero {Doctor.Gender}");
      Console.WriteLine($"Telefono {Doctor.Phone}");
      Console.WriteLine($"Especialidad {Doctor.Speciality}");
      Console.WriteLine($"Estado {Doctor.Status}");

   }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
