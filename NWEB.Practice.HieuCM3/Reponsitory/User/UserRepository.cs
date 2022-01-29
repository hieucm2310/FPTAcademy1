using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Model.Requests;
using Model.Response;
using Model.User;

namespace Reponsitory.User
{
    public class UserRepository : Repository<UserRepository>, IUserRepository
    {
        private readonly IConfiguration _configuration;
        public UserRepository(
            IConfiguration configuration,
            OTContext context
            ) : base(context)
        {
            _configuration = configuration;
        }

        public TableResponse<UserViewModel> GetListUser(SearchCategoryModel search)
        {
            TableResponse<UserViewModel> result = new TableResponse<UserViewModel>();
            result.Draw = search.Draw;

            try
            {
                var data = _context.Users.Where(x => x.IsDelete == false).Select(x => new UserViewModel
                {
                    FullName = x.FullName,
                    Password = x.Password,
                    Role = x.Role

                }).ToList();

                if (search.SearchValue != null)
                {
                    data = data.Where(x => x.FullName.ToLower().Contains(search.SearchValue.ToLower())).ToList();
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
                result.Message = "Xảy ra lỗi khi lấy danh sách user!";
            }
            return result;
        }
    }
}
