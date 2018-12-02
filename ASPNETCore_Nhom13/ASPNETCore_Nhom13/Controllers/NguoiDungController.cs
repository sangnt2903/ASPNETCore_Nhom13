using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCore_Final.Models;
using ASPNETCore_Nhom13.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Nhom13.Controllers
{
    public class NguoiDungController : Controller
    {
        private readonly MyDbContext _context;

        public NguoiDungController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                NguoiDung kh = _context.NguoiDungs.SingleOrDefault(p => p.HoTen == model.Email && p.MatKhau == model.matKhau);
                if (kh == null)
                {
                    ModelState.AddModelError("Loi", "Không có khách hàng này.");
                    return View();
                }
                //ghi session
                //HttpContext.Session.SetString("MaKH", kh.MaKh);
                HttpContext.Session.Set("admin", kh);
                //chuyển tới trang HangHoa (--> MyProfile)
                return RedirectToAction("Index", "TinTucs");
            }
            return View("Index");
        }
    }
}