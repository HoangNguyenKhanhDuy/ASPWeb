﻿using BaiTap07.Data;
using BaiTap07.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BaiTap07.Controllers
{
    public class TheLoaiController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TheLoaiController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var theloai = _db.TheLoai.ToList();
            ViewBag.TheLoai = theloai;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TheLoai theloai)
        {
            if (ModelState.IsValid)
            {
                //Thêm thông tin
                _db.TheLoai.Add(theloai);
                //Lưu
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.TheLoai.Find(id);
            return View(theloai);
        }

        [HttpPost]
        public IActionResult Edit(TheLoai theloai)
        {
            if (ModelState.IsValid)
            {
                //Thêm thông tin
                _db.TheLoai.Update(theloai);
                //Lưu
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Detail(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.TheLoai.Find(id);
            return View(theloai);
        }

        public IActionResult Search(String searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                var theloai = _db.TheLoai.
                    Where(tl => tl.Name.Contains(searchString)).ToList();

                ViewBag.SearchString = searchString;
                ViewBag.TheLoai = theloai;
            }
            else
            {
                var theloai = _db.TheLoai.ToList();
                ViewBag.TheLoai = theloai;
            }


            return View("Index");
        }


        [HttpPost]
        public IActionResult Detail(TheLoai theloai)
        {
            if (ModelState.IsValid)
            {
                //Thêm thông tin
                _db.TheLoai.Update(theloai);
                //Lưu
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.TheLoai.Find(id);
            return View(theloai);
        }



        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var theloai = _db.TheLoai.Find(id);
            if (theloai == null)
            {
                return NotFound();
            }
            _db.TheLoai.Remove(theloai);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}