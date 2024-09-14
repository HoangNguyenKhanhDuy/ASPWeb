using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class TaiKhoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DangKy(TaiKhoanViewModel taikhoan)
        {
            if (taikhoan != null)
            {
       
                if (!string.IsNullOrEmpty(taikhoan.Password) && taikhoan.Password.Length > 0)
                {
                    taikhoan.Password = taikhoan.Password + "_da_ma_hoa";
                }

                if (string.IsNullOrEmpty(taikhoan.Name))
                {
                    ModelState.AddModelError("HoTen", "Họ tên không được bỏ trống");
                }

                if (taikhoan.Age <= 0)
                {
                    ModelState.AddModelError("Tuoi", "Tuổi phải lớn hơn 0");
                }
                if (ModelState.IsValid)
                {
                    return View(taikhoan);
                }
            }
            return View(taikhoan);
        }
    }
}
