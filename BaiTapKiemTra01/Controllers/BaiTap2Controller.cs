using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class BaiTap2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BaiTap2(SanPhamViewModel sanPham)
        {
            var sanpham = new SanPhamViewModel()
            {
                TenSanPham = "Iphone14",
                GiaBan = 30000000,  // 30 triệu VND
                AnhMoTa = "/images/DienThoai.jpg"
            };


            return View(sanpham);
        }
    }
}
