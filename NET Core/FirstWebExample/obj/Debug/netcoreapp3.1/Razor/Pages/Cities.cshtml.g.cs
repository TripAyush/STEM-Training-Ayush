#pragma checksum "C:\STEM Training\NET Core\FirstWebExample\Pages\Cities.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c44c73730e6c84377aa63f5ee954e46687615bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FirstWebExample.Pages.Pages_Cities), @"mvc.1.0.razor-page", @"/Pages/Cities.cshtml")]
namespace FirstWebExample.Pages
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
#line 1 "C:\STEM Training\NET Core\FirstWebExample\Pages\_ViewImports.cshtml"
using FirstWebExample;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c44c73730e6c84377aa63f5ee954e46687615bb", @"/Pages/Cities.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e841ee922023e5176d864cfe120ea0a00baa106d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cities : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\STEM Training\NET Core\FirstWebExample\Pages\Cities.cshtml"
  
    List<string> cities = new List<string>();
    cities.Add("Delhi");
    cities.Add("Bangalore");
    cities.Add("Hyderabad");
    cities.Add("Mumbai");
    cities.Add("Pune");
    cities.Add("Chandigarh");

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n<ul>\r\n");
#nullable restore
#line 14 "C:\STEM Training\NET Core\FirstWebExample\Pages\Cities.cshtml"
     foreach(var c in cities)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 16 "C:\STEM Training\NET Core\FirstWebExample\Pages\Cities.cshtml"
               Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 17 "C:\STEM Training\NET Core\FirstWebExample\Pages\Cities.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FirstWebExample.Pages.CitiesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FirstWebExample.Pages.CitiesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FirstWebExample.Pages.CitiesModel>)PageContext?.ViewData;
        public FirstWebExample.Pages.CitiesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
