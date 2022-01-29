using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Category;
using Model.Requests;
using Model.Response;

namespace Reponsitory.Category
{
    public interface ICategoryRepository
    {
        Response<CategoryModel> GetCategoryById(CategoryModel model);
        TableResponse<CategoryViewModel> GetListCategory(SearchCategoryModel search);
        Response<string> CreateCategory(CategoryModel model);
        Response<string> DeleteCategory(CategoryModel model);
        Response<string> UpdateCategory(CategoryModel model);
    }
}
