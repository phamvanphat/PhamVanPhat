using DoAnThucTap.DTOs.Attributes;
using System.ComponentModel.DataAnnotations;

namespace DoAnThucTap.Web.Areas.Admin.ViewModels.User
{
    public class AddUserVM
    {
        [AppRequired]
        public string UserName { get; set; }
        [AppRequired]
        public string Password { get; set; }
        [Compare(nameof(Password), ErrorMessage = "Mật khẩu không khớp")]
        public string ComformPassword { get; set; }
        [AppRequired]
        public string Gmail { get; set; }
        [AppRequired]
        public string SDT { get; set; }
        public bool IsAdmin { get; set; }
        public byte[]? PasswordHash { get; internal set; }
        public byte[]? PasswordSalt { get; internal set; }
    }
}
