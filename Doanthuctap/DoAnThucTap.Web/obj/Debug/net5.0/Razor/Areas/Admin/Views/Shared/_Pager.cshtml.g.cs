#pragma checksum "D:\hoaibao\DuAN\QuanLyThuVien\DoAN\Doanthuctap\DoAnThucTap.Web\Areas\Admin\Views\Shared\_Pager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1516eaa0caa7eef6ef1c9178561a60cd8ca1cf4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Pager), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Pager.cshtml")]
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
#line 1 "D:\hoaibao\DuAN\QuanLyThuVien\DoAN\Doanthuctap\DoAnThucTap.Web\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnThucTap.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\hoaibao\DuAN\QuanLyThuVien\DoAN\Doanthuctap\DoAnThucTap.Web\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnThucTap.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\hoaibao\DuAN\QuanLyThuVien\DoAN\Doanthuctap\DoAnThucTap.Web\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnThucTap.DTOs.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\hoaibao\DuAN\QuanLyThuVien\DoAN\Doanthuctap\DoAnThucTap.Web\Areas\Admin\Views\Shared\_Pager.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\hoaibao\DuAN\QuanLyThuVien\DoAN\Doanthuctap\DoAnThucTap.Web\Areas\Admin\Views\Shared\_Pager.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\hoaibao\DuAN\QuanLyThuVien\DoAN\Doanthuctap\DoAnThucTap.Web\Areas\Admin\Views\Shared\_Pager.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1516eaa0caa7eef6ef1c9178561a60cd8ca1cf4d", @"/Areas/Admin/Views/Shared/_Pager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60697112180372a41c52176955326f2148e0543d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared__Pager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\hoaibao\DuAN\QuanLyThuVien\DoAN\Doanthuctap\DoAnThucTap.Web\Areas\Admin\Views\Shared\_Pager.cshtml"
  
	string _params = "";
	foreach (var item in Context.Request.Query)
	{
		if (item.Key != "page")
		{
			_params += $"&{item.Key}={item.Value}";
		}
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"my-4\">\r\n");
#nullable restore
#line 18 "D:\hoaibao\DuAN\QuanLyThuVien\DoAN\Doanthuctap\DoAnThucTap.Web\Areas\Admin\Views\Shared\_Pager.cshtml"
Write(Html.PagedListPager(Model,
	page => Url.Action("Index", new { page = page, area = "Admin" }) + _params,
	new PagedListRenderOptions
	{
		LiElementClasses = new string[] { "page-item" },
		PageClasses = new string[] { "page-link" },
	}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t<div class=\"mt-2 small font-italic\">Danh sách này có tổng cộng ");
#nullable restore
#line 25 "D:\hoaibao\DuAN\QuanLyThuVien\DoAN\Doanthuctap\DoAnThucTap.Web\Areas\Admin\Views\Shared\_Pager.cshtml"
                                                              Write(Model.TotalItemCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" bản ghi</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591