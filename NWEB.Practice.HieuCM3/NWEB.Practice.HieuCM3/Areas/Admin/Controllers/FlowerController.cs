using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Reponsitory.Flower;

namespace NWEB.Practice.HieuCM3.Areas.Admin.Controllers
{
    [Area("admin")]
    public class FlowerController : BaseController
    {
        private readonly IFlowerRepository _categoryRepository;
        private readonly IToastNotification _toastNotification;

        public FlowerController(
          IFlowerRepository categoryRepository,
          IToastNotification toastNotification)
        {
            _categoryRepository = categoryRepository;
            _toastNotification = toastNotification;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
