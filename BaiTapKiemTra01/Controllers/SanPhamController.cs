using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BaiTap2(SanPhamViewModel SanPham)
        {
            var sanPham = new SanPhamViewModel
            {
                TenSanPham = "Điện thoại",
                GiaBan = 15000000,
                AnhMoTa = "<img src='/images/DienThoai.jpg' alt='DienThoai' />"
            };
            return View(SanPham);
        }
    }
}
