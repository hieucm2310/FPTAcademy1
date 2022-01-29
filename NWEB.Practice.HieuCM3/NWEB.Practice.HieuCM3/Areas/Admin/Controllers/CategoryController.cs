using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Category;
using Model.Requests;
using Model.Response;
using NToastNotify;
using Reponsitory.Category;

namespace NWEB.Practice.HieuCM3.Areas.Admin.Controllers
{
    [Area("admin")]
    public class CategoryController : BaseController
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IToastNotification _toastNotification;

        public CategoryController(
          ICategoryRepository categoryRepository,
          IToastNotification toastNotification)
        {
            _categoryRepository = categoryRepository;
            _toastNotification = toastNotification;
        }
        [Route("admin/danh-sach-danh-muc")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("admin/getlit")]
        public IActionResult GetListCategory(string searchValue)
        {
            SearchCategoryModel searchModel = talbeSearchModel.Get<SearchCategoryModel>();
            searchModel.SearchValue = searchValue;
            var data = _categoryRepository.GetListCategory(searchModel);
            //if (data.Code != StatusCodes.Status200OK)
            //    _toastNotification.AddErrorToastMessage(data.Message);
            return Json(data);
        }
        [Route("admin/taodm")]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [Route("admin/insot")]
        [HttpPost]
        public IActionResult InsertCategory(CategoryModel model)
        {
            var res = _categoryRepository.CreateCategory(model);
            if (res.Code == StatusCodes.Status200OK)
            {
                _toastNotification.AddSuccessToastMessage(res.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(res.Message);
            }
            return Json(res);
        }
        [Route("admin/delit")]
        [HttpPost]
        public IActionResult DeleteCategory(int Id)
        {
            var model = new CategoryModel();
            model.Id = Id;
            var res = _categoryRepository.DeleteCategory(model);
            if (res.Code == StatusCodes.Status200OK)
            {
                _toastNotification.AddSuccessToastMessage(res.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(res.Message);
            }
            return Json(res);
        }

        [Route("sua-danh-muc/{id}")]
        public IActionResult EditCategory(int Id)
        {
            var model = new CategoryModel();
            model.Id = Id;
            var res = _categoryRepository.GetCategoryById(model);

            if (res == null)
                res = new Response<CategoryModel>();
            if (res.Data == null)
                res.Data = new CategoryModel();

            return View(res.Data);
        }

        [Route("admin/apdet")]
        [HttpPost]
        public IActionResult UpdateCategory(CategoryModel model)
        {
            var res = _categoryRepository.UpdateCategory(model);
            if (res.Code == StatusCodes.Status200OK)
            {
                _toastNotification.AddSuccessToastMessage(res.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(res.Message);
            }
            return Json(res);
        }
    }
}
