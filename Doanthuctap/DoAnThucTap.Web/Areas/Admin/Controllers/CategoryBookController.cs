using AutoMapper;
using DoAnThucTap.Data.Reponsitory;
using DoAnThucTap.DTOs.Entyties;
using DoAnThucTap.Web.Areas.Admin.ViewModels.CategoryBook;
using DoAnThucTap.Web.Areas.Admin.ViewModels.User;
using DoAnThucTap.Web.WebConfig;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using X.PagedList;

namespace DoAnThucTap.Web.Areas.Admin.Controllers
{
    public class CategoryBookController : BaseController
    {
        public readonly IMapper _mapper;
        public CategoryBookController(BaseReponsitory _repo, IMapper mapper) :base(_repo)
        {
            _mapper=mapper;
        }
        public IActionResult Index(int page=1,int size=10)
        {
            var data = _repo.GetAll<CategoryBook, ListCategoryBookVM>(MapperConfig.CategoryBookIndexConf)
                            .ToPagedList(page, size);
            return View(data);
        }
        public IActionResult _AddCategoryBook()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> _AddCategoryBook(AddorUpdateCategoryBook model)
        {
            var data =_mapper.Map<CategoryBook>(model);
            await _repo.AddAsync(data);
            SetSuccessMesg("Thêm dữ liệu thành công");
            return Ok(true);
        }
        public async Task<IActionResult> _Update(int id)
        {
            var data = await _repo.GetOneAsync<CategoryBook, AddorUpdateCategoryBook>(id, b => new AddorUpdateCategoryBook
            {
                Id = b.Id,
                CategoryBookName = b.CategoryBookName,
            });
            return PartialView(data);
        }
        [HttpPost]
        public async Task<IActionResult> _Update(AddorUpdateCategoryBook model)
        {
            var data=await _repo.FindAsync<CategoryBook>(model.Id);
            if(data == null)
            {
                SetErrorMesg("Cật nhật không thành công");
            }
            _mapper.Map<AddorUpdateCategoryBook,CategoryBook>(model,data);
            data.UpdateAt=DateTime.Now;
            await _repo.UpdateAsync(data);
            return Ok(true);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _repo.FindAsync<CategoryBook>(id);
            await _repo.DeleteAsync(data);
            SetSuccessMesg("Xóa thể loại " + data.CategoryBookName + " thành công");
            return RedirectToAction("Index");
        }
    }
}
