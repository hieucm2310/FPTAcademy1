using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Entity.Context;
using Entity.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NToastNotify;
using NWEB.Practice.HieuCM3.Models;
using Reponsitory.User;

namespace NWEB.Practice.HieuCM3.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IToastNotification _toastNotification;
        public readonly OTContext _context;

        public HomeController(
          IUserRepository userRepository,
          OTContext context,
          IToastNotification toastNotification)
        {
            _userRepository = userRepository;
            _toastNotification = toastNotification;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(IFormCollection collection)
        {
            string ten = collection["Ten"];
            string matkhau = collection["MatKhau"];
            ViewBag.ThongBao = ten + matkhau;
            if (String.IsNullOrEmpty(ten))
            {
                { ViewData["Loi1"] = "Phải nhập tên đăng nhập"; }
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                { ViewData["Loi2"] = "Phải nhập mật khẩu"; }
            }
            else
            {
                User u = _context.Users
                    .Where(n => n.FullName.Trim() == ten)
                    .FirstOrDefault();
                if (u == null)
                {
                    ViewBag.Thongbao = "Tên tài khoản không tồn tại";
                }
                else
                {
                    if (!u.Role)
                    {
                        if (u.Password.Equals(matkhau))
                        {
                            HttpContext.Session.SetString("name", u.FullName);
                            ViewBag.Thongbao = $"Đăng nhập tài khoản người dùng {u.FullName} thành công,";
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không đúng";
                        }
                    }
                    if (u.Role)
                    {
                        if (u.Password.Equals(matkhau))
                        {
                            HttpContext.Session.SetString("name", "admin");
                            //return RedirectToAction("Index", "Home", new { Areas = "exists" });
                            return Redirect("~/admin");
                        }
                        else
                        {
                            ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không đúng";
                        }
                    }
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult SeeCategory()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
