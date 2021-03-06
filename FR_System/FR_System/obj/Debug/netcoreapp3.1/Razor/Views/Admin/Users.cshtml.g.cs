#pragma checksum "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4acd165ae3e389ba855e2e0adbf51eb944c355e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Users), @"mvc.1.0.view", @"/Views/Admin/Users.cshtml")]
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
#line 1 "E:\proj\FR_Team50\FR_System\FR_System\Views\_ViewImports.cshtml"
using FR_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\proj\FR_Team50\FR_System\FR_System\Views\_ViewImports.cshtml"
using FR_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4acd165ae3e389ba855e2e0adbf51eb944c355e5", @"/Views/Admin/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b9eb7095bd7e9c801be11298e89ddeb35f09fd4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FR_System.Models.User>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserReservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mx-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger w-20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml"
  
    ViewData["Title"] = "User Details";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""page-wrapper"">
			<div class=""main-page"">
				<h2 class=""title1"">Index-User Details</h2>
				<div class=""blank-page widget-shadow scroll"" id=""style-2 div1"">
<div class=""container p-3"">
	<div class=""row pt-4"">
		<div class=""col-6"">
			<h2 class=""text-primary"">User Details List</h2>
		</div>
	</div>
	<br />

");
#nullable restore
#line 21 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml"
     if(Model.Count() > 0)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		<table class=""table table-bordered table-striped"" style=""width:90%"">
			<thead>
				<tr>
					<th>User Id</th>
					<th>First Name</th>
					<th>Last Name</th>
					<th>User Name</th>
					<th>Gender</th>
					<th>Age</th>
					<th>Address</th>
					<th>Phone No</th>
					<th>Email</th>
					<th>Action</th>
				</tr>
			</thead>
			<tbody>
");
#nullable restore
#line 39 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml"
                 foreach (var item in Model)
			   {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t   <tr>\r\n\t\t\t\t\t   <td width=\"10%\">");
#nullable restore
#line 42 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml"
                                  Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t   <td width=\"10%\">");
#nullable restore
#line 43 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml"
                                  Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t   <td width=\"10%\">");
#nullable restore
#line 44 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml"
                                  Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t   <td width=\"10%\">");
#nullable restore
#line 45 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml"
                                  Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t   <td width=\"10%\">");
#nullable restore
#line 46 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml"
                                  Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t   <td width=\"10%\">");
#nullable restore
#line 47 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml"
                                  Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t   <td width=\"10%\">");
#nullable restore
#line 48 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml"
                                  Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t   <td width=\"10%\">");
#nullable restore
#line 49 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml"
                                  Write(item.PhoneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t   <td width=\"10%\">");
#nullable restore
#line 50 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml"
                                  Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t   <td width=\"20%\">\r\n\t\t\t\t\t\t   <div class=\"w-100 btn-group\" role=\"group\">\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4acd165ae3e389ba855e2e0adbf51eb944c355e58725", async() => {
                WriteLiteral("View Reservation");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml"
                                                                                         WriteLiteral(item.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t   </div>\r\n\t\t\t\t\t   </td>\r\n\t\t\t\t   </tr>\r\n");
#nullable restore
#line 57 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml"
			   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</tbody>\r\n\t\t</table>\r\n");
#nullable restore
#line 60 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml"
	}
	else
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<p>No User details available.</p>\r\n");
#nullable restore
#line 64 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Users.cshtml"

	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4acd165ae3e389ba855e2e0adbf51eb944c355e511913", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n</div>\r\n</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FR_System.Models.User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
