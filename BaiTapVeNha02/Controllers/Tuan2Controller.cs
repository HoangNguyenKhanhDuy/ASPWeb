using Microsoft.AspNetCore.Mvc;

namespace BaiTapVeNha02.Controllers
{
    public class Tuan2Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Hoang Nguyen Khanh Duy";
            ViewBag.MSSV = "1822031167";
            ViewBag.Nam = 2024;

            return View();
        }
    }
}
