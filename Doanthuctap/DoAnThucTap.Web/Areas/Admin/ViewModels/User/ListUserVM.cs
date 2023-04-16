using System;

namespace DoAnThucTap.Web.Areas.Admin.ViewModels.User
{
    public class ListUserVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Gmail { get; set; }
        public string SDT { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
