using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Model.Category;
using Model.Requests;
using Model.Response;

namespace Reponsitory.Category
{
    public class CategoryRepository : Repository<CategoryRepository>, ICategoryRepository
    {
        private readonly IConfiguration _configuration;
        public CategoryRepository(
            IConfiguration configuration,
            OTContext context
            ) : base(context)
        {
            _configuration = configuration;
        }

        public Response<CategoryModel> GetCategoryById(CategoryModel model)
        {
            Response<CategoryModel> res = new Response<CategoryModel>();

            try
            {
                var query = (from a in _context.Categories
                             where a.Id == model.Id
                             select new
                             {
                                 a
                             }).ToList();

                var group = query.GroupBy(x => x.a.Oder).Select(group => new CategoryModel
                {
                    Oder = group.Key,
                    CategoryName = group.ToList().FirstOrDefault().a.CategoryName,
                    Text = group.ToList().FirstOrDefault().a.Text
                }).ToList();

                res.Code = StatusCodes.Status200OK;
                res.Data = group.FirstOrDefault();
            }
            catch (Exception ex)
            {
                res.Code = StatusCodes.Status400BadRequest;
                res.Message = "Xảy ra lỗi khi lấy thông tin thành phố!";
            }

            return res;
        }

        public TableResponse<CategoryViewModel> GetListCategory(SearchCategoryModel search)
        {
            TableResponse<CategoryViewModel> result = new TableResponse<CategoryViewModel>();
            result.Draw = search.Draw;

            try
            {
                var data = _context.Categories.Where(x => x.IsDelete == false).Select(x => new CategoryViewModel
                {
                    Id = x.Id,
                    CategoryName = x.CategoryName,
                    Oder = x.Oder,
                    Text = x.Text

                }).ToList();

                if (search.SearchValue != null)
                {
                    data = data.Where(x => x.CategoryName.ToLower().Contains(search.SearchValue.ToLower())).ToList();
                }

                var cnt = data.Count();
                result.Data = data.OrderBy(x => x.Id).Skip(search.Start).Take(search.Length).ToList();
                result.RecordsTotal = cnt;
                result.RecordsFiltered = cnt;
                result.Code = StatusCodes.Status200OK;
            }
            catch (Exception ex)
            {
                result.Code = StatusCodes.Status500InternalServerError;
                result.Message = "Xảy ra lỗi khi lấy danh sách danh mục!";
            }
            return result;
        }
        public Response<string> CreateCategory(CategoryModel model)
        {
            Response<string> res = new Response<string>();

            try
            {
                if (string.IsNullOrEmpty(model.CategoryName))
                {
                    res.Code = StatusCodes.Status400BadRequest;
                    res.Message = "Tên danh mục không được bỏ trống!";
                    return res;
                }

                Entity.Entity.Category category = new Entity.Entity.Category();
                category.CategoryName = model.CategoryName;
                category.Text = model.Text;
                category.Oder = model.Oder;

                _context.Categories.Add(category);
                _context.SaveChanges();

                res.Code = StatusCodes.Status200OK;
                res.Message = "Thêm danh mục thành công!";
                return res;
            }
            catch (Exception ex)
            {
                res.Code = StatusCodes.Status500InternalServerError;
                res.Message = "Xảy ra lỗi khi thêm danh mục!";
            }

            return res;
        }
        public Response<string> DeleteCategory(CategoryModel model)
        {
            Response<string> res = new Response<string>();

            try
            {
                var category = _context.Categories.FirstOrDefault(x => x.Id == model.Id && x.IsDelete == false);
                if (category == null)
                {
                    res.Code = StatusCodes.Status404NotFound;
                    res.Message = "Không tồn tại danh mục, không thể xóa!";
                    return res;
                }
                category.IsDelete = true;
                _context.Categories.Update(category);
                _context.SaveChanges();

                res.Code = StatusCodes.Status200OK;
                res.Message = "Xóa danh mục thành công!";
                return res;
            }
            catch (Exception ex)
            {
                res.Code = StatusCodes.Status500InternalServerError;
                res.Message = "Xảy ra lỗi khi xóa danh mục!";
            }

            return res;
        }
        public Response<string> UpdateCategory(CategoryModel model)
        {
            Response<string> res = new Response<string>();

            try
            {
                if (string.IsNullOrEmpty(model.CategoryName))
                {
                    res.Code = StatusCodes.Status400BadRequest;
                    res.Message = "Tên danh mục không được bỏ trống!";
                    return res;
                }
                if (string.IsNullOrEmpty(model.Text))
                {
                    res.Code = StatusCodes.Status400BadRequest;
                    res.Message = "Text danh mục không được bỏ trống!";
                    return res;
                }

                if (model.Oder == 0)
                {
                    res.Code = StatusCodes.Status400BadRequest;
                    res.Message = "Oder danh mục không được bỏ trống!";
                    return res;
                }

                var category = _context.Categories.FirstOrDefault(x => x.IsDelete == false && x.Id == model.Id);
                if (category == null)
                {
                    res.Code = StatusCodes.Status404NotFound;
                    res.Message = "Không tồn tại danh mục, không thể cập nhật!";
                    return res;
                }

                category.CategoryName = model.CategoryName;
                category.Oder = model.Oder;
                category.Text = model.Text;
                _context.Categories.Update(category);
                _context.SaveChanges();

                res.Code = StatusCodes.Status200OK;
                res.Message = "Sửa danh mục thành công!";
                return res;
            }
            catch (Exception ex)
            {
                res.Code = StatusCodes.Status500InternalServerError;
                res.Message = "Xảy ra lỗi khi sửa danh mục!";
            }

            return res;
        }
    }
}