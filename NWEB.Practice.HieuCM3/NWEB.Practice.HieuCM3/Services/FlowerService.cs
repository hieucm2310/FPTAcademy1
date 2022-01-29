using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Context;
using Model;

namespace NWEB.Practice.HieuCM3.Services
{
    public class FlowerService
    {
        //OTContext ot;
        //public Flower Find(int flowerId)
        //{
        //    var context2 = ot;
        //    var flower = context2.Flowers.Where(s => s.Id == flowerId).FirstOrDefault();
        //    Flower result = new Flower();
        //    result.Id = flower.Id;
        //    result.CategoryId = flower.Category.Id;
        //    result.FlowerName = flower.FlowerName;
        //    result. = category.;
        //    return result;
        //}

        //public void AddCategory(Category category)
        //{
        //    using (var context = ot)
        //    {
        //        context.Add<Category>(category);
        //        context.SaveChanges();
        //    }
        //}

        //public void UpdateCategory(Category category)
        //{
        //    Console.Write("Enter name category:");
        //    string name = Console.ReadLine();
        //    Console.Write("Enter urlslug:");
        //    string urlslug = Console.ReadLine();
        //    Console.Write("Enter description:");
        //    string description = Console.ReadLine();
        //    var std = new Category() { Id = category.Id, Name = name, UrlSlug = urlslug, Description = description };
        //    using (var context = new JustBlogContext())
        //    {
        //        context.Update<Category>(std);
        //        context.SaveChanges();
        //    }
        //}
        //public void DeleteCategory(Category category)
        //{
        //    using (var context = new JustBlogContext())
        //    {
        //        try
        //        {
        //            context.Remove<Category>(category);
        //            context.SaveChanges();
        //        }
        //        catch (DbUpdateConcurrencyException ex)
        //        {
        //            throw new Exception("Record does not exist in the database");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw;
        //        }
        //    }
        //}
        //public IList<Category> GetAllCategories()
        //{
        //    var context2 = new JustBlogContext();
        //    var categories = context2.Categories.ToList();
        //    List<Category> listCategories = new List<Category>();
        //    foreach (var item in categories)
        //    {
        //        listCategories.Add(item);
        //    }
        //    return listCategories;
        //}
        //public void GetRoleById(Flower model)
        //{
        //    try
        //    {
        //        var query = (from a in ot.Flowers
        //                     where a.IsDelete == false && a.Id == model.Id
        //                     select new
        //                     {
        //                         a
        //                     }).ToList();

        //        var group = query.GroupBy(x => x.a.Id).Select(group => new RoleModel
        //        {
        //            Id = group.Key,
        //            RoleName = group.ToList().FirstOrDefault().a.Name
        //        }).ToList();

        //        res.Code = StatusCodes.Status200OK;
        //        res.Data = group.FirstOrDefault();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "");
        //        res.Code = StatusCodes.Status400BadRequest;
        //        res.Message = "Xảy ra lỗi khi lấy thông tin nhóm quyền!";
        //    }

        //    return res;
        //}
    }
}
