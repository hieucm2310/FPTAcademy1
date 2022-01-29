using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.Requests;

namespace NWEB.Practice.HieuCM3.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        public TableSearchModel talbeSearchModel
        {
            get
            {
                TableSearchModel search = new TableSearchModel();
                var draw = Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();
                var searchValue = Request.Form["search[value]"].FirstOrDefault();
                var orderColumn = Request.Form["order[0][column]"].FirstOrDefault();
                var orderDir = Request.Form["order[0][dir]"].FirstOrDefault();
                search.Draw = int.Parse(draw);
                search.Start = int.Parse(start);
                search.Length = int.Parse(length);
                search.SearchValue = searchValue;
                search.OrderColumn = int.Parse(orderColumn);
                search.OrderDir = orderDir;
                return search;
            }
        }
    }
}
