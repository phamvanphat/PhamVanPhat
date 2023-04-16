using DoAnThucTap.Data.Reponsitory;
using DoAnThucTap.DTOs.Const;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DoAnThucTap.Web.Areas.Admin.Components.MainNavBar
{
    public class MainNavBarViewComponent : ViewComponent
    {
        readonly BaseReponsitory repository;
        public MainNavBarViewComponent(BaseReponsitory _repository)
        {
            repository = _repository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var navBar = new NavBarViewModel();
            navBar.Items.AddRange(new MenuItem[]
            {
                 new MenuItem
                {
                            Action = "Index",
                            Controller = "Voucher",
                            DisplayText = "Mã giảm giá",
                            Icon = "fa-receipt",
                            //Permission = AuthConst.Voucher.VIEW_LIST
                }
            });
            return View(navBar);
        }
    }    
}
