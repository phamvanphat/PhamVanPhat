using AutoMapper;
using static DoAnThucTap.Web.WebConfig.Const.VM;
using System.Drawing;
using DoAnThucTap.DTOs.Entyties;
using DoAnThucTap.Web.Areas.Admin.ViewModels.User;
using DoAnThucTap.Web.Areas.Admin.ViewModels.CategoryBook;

namespace DoAnThucTap.Web.WebConfig
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<User, AddUserVM>().ReverseMap();

            CreateMap<CategoryBook, AddorUpdateCategoryBook>().ReverseMap();

        }
        public static MapperConfiguration UserIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<User, ListUserVM>();
        }); public static MapperConfiguration CategoryBookIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<CategoryBook, ListCategoryBookVM>();
        });
    }
}
