#pragma checksum "C:\Users\Teja\Desktop\Team50_FR\FR_Team50\FR_System\FR_System\Views\Plane\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdfe9ec1040a622363e9815b84c1aacfded08b8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plane_Details), @"mvc.1.0.view", @"/Views/Plane/Details.cshtml")]
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
#line 1 "C:\Users\Teja\Desktop\Team50_FR\FR_Team50\FR_System\FR_System\Views\_ViewImports.cshtml"
using FR_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Teja\Desktop\Team50_FR\FR_Team50\FR_System\FR_System\Views\_ViewImports.cshtml"
using FR_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdfe9ec1040a622363e9815b84c1aacfded08b8a", @"/Views/Plane/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b9eb7095bd7e9c801be11298e89ddeb35f09fd4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Plane_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FR_System.Models.Plane>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Plane Information</h1>\r\n<div class=\"container p-3\">\r\n\t<div class=\"row pt-4\">\r\n\t\t<div class=\"col-6\">\r\n\t\t\t<h2 class=\"text-primary\">Plane Details List</h2>\r\n\t\t</div>\r\n\t</div>\r\n\t<br />\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Teja\Desktop\Team50_FR\FR_Team50\FR_System\FR_System\Views\Plane\Details.cshtml"
     if(Model.Count() > 0)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<table class=\"table table-bordered table-striped\" style=\"wif=dth:100%\">\r\n\t\t\t<thead>\r\n\t\t\t\t<tr>\r\n\t\t\t\t\t<th>PlaneID</th>\r\n\t\t\t\t\t<th>Plane Name</th>\r\n\t\t\t\t\t<th>Number of Seats</th>\r\n\t\t\t\t</tr>\r\n\t\t\t</thead>\r\n\t\t\t<tbody>\r\n");
#nullable restore
#line 23 "C:\Users\Teja\Desktop\Team50_FR\FR_Team50\FR_System\FR_System\Views\Plane\Details.cshtml"
                 foreach (var item in Model)
			   {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t   <tr>\r\n\t\t\t\t\t   <td width=\"30%\">");
#nullable restore
#line 26 "C:\Users\Teja\Desktop\Team50_FR\FR_Team50\FR_System\FR_System\Views\Plane\Details.cshtml"
                                  Write(item.PlaneID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t   <td width=\"30%\">");
#nullable restore
#line 27 "C:\Users\Teja\Desktop\Team50_FR\FR_Team50\FR_System\FR_System\Views\Plane\Details.cshtml"
                                  Write(item.PlaneName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t   <td width=\"30%\">");
#nullable restore
#line 28 "C:\Users\Teja\Desktop\Team50_FR\FR_Team50\FR_System\FR_System\Views\Plane\Details.cshtml"
                                  Write(item.Seats);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t   </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Teja\Desktop\Team50_FR\FR_Team50\FR_System\FR_System\Views\Plane\Details.cshtml"
			   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</tbody>\r\n\t\t</table>\r\n");
#nullable restore
#line 33 "C:\Users\Teja\Desktop\Team50_FR\FR_Team50\FR_System\FR_System\Views\Plane\Details.cshtml"
	}
	else
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<p>No flight details available.</p>\r\n");
#nullable restore
#line 37 "C:\Users\Teja\Desktop\Team50_FR\FR_Team50\FR_System\FR_System\Views\Plane\Details.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FR_System.Models.Plane>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591