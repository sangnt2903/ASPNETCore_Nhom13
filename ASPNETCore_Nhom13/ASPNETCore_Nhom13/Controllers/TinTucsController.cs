﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPNETCore_Nhom13.Models;
<<<<<<< HEAD
using ASPCore_Final.Models;
=======
using Microsoft.AspNetCore.Http;
using System.IO;
>>>>>>> 2ef27eff1f4d11fa7085bcf09fc8afaebc76476d

namespace ASPNETCore_Nhom13.Controllers
{
    public class TinTucsController : Controller
    {
        private readonly MyDbContext _context;

        public TinTucsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: TinTucs
        public IActionResult Index()
        {
<<<<<<< HEAD
            List<TinTuc> res = new List<TinTuc>();
            if(HttpContext.Session.Get<string>("admin") != null)
            {
               // res = _context.TinTucs.
            }
            return View();
=======
            List<TinTuc> dsTin = new List<TinTuc>();
            if (HttpContext.Session.Get("admin") != null)
            {
                dsTin = _context.TinTucs.OrderBy(p => p.NgayDang).ToList();
            }
            return View(dsTin);
        }

        public IActionResult DuyetBai(int matin)
        {
            if (HttpContext.Session.Get("admin") != null)
            {
                TinTuc t = _context.TinTucs.SingleOrDefault(p => p.MaTin == matin);
                t.TrangThai = true;
                _context.SaveChanges();
            }
            
            return RedirectToAction("Index");
>>>>>>> 2ef27eff1f4d11fa7085bcf09fc8afaebc76476d
        }

        // GET: TinTucs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinTuc = await _context.TinTucs
                .Include(t => t.NguoiDung)
                .Include(t => t.TheLoai)
                .FirstOrDefaultAsync(m => m.MaTin == id);
            if (tinTuc == null)
            {
                return NotFound();
            }

            return View(tinTuc);
        }

        // GET: TinTucs/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.Get("admin") != null)
            {
                ViewData["MaNguoiDung"] = new SelectList(_context.NguoiDungs, "MaNguoiDung", "HoTen");
                ViewData["MaTheLoai"] = new SelectList(_context.TheLoais, "MaTheLoai", "TenTheLoai");
                
            }
            else
            {
                return RedirectToAction("Index", "NguoiDung");
            }
            return View();
        }

        // POST: TinTucs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult Create(TinTuc tinTuc,IFormFile fHinh)
        {
            if (ModelState.IsValid)
            {
                tinTuc.TrangThai = false;
                if (fHinh != null)
                {
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Hinh", fHinh.FileName);
                    using (var file = new FileStream(path, FileMode.Create))
                    {
                        fHinh.CopyTo(file);
                    }
                    tinTuc.Hinh = fHinh.FileName;
                }
                _context.Add(tinTuc);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["MaNguoiDung"] = new SelectList(_context.NguoiDungs, "MaNguoiDung", "HoTen", tinTuc.MaNguoiDung);
            ViewData["MaTheLoai"] = new SelectList(_context.TheLoais, "MaTheLoai", "TenTheLoai", tinTuc.MaTheLoai);
            return View(tinTuc);
        }

        // GET: TinTucs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinTuc = await _context.TinTucs.FindAsync(id);
            if (tinTuc == null)
            {
                return NotFound();
            }
            ViewData["MaNguoiDung"] = new SelectList(_context.NguoiDungs, "MaNguoiDung", "HoTen", tinTuc.MaNguoiDung);
            ViewData["MaTheLoai"] = new SelectList(_context.TheLoais, "MaTheLoai", "TenTheLoai", tinTuc.MaTheLoai);
            return View(tinTuc);
        }

        // POST: TinTucs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaTin,TieuDe,NoiDung,Hinh,NgayDang,MaTheLoai,MaNguoiDung")] TinTuc tinTuc)
        {
            if (id != tinTuc.MaTin)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tinTuc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TinTucExists(tinTuc.MaTin))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaNguoiDung"] = new SelectList(_context.NguoiDungs, "MaNguoiDung", "HoTen", tinTuc.MaNguoiDung);
            ViewData["MaTheLoai"] = new SelectList(_context.TheLoais, "MaTheLoai", "TenTheLoai", tinTuc.MaTheLoai);
            return View(tinTuc);
        }

        // GET: TinTucs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinTuc = await _context.TinTucs
                .Include(t => t.NguoiDung)
                .Include(t => t.TheLoai)
                .FirstOrDefaultAsync(m => m.MaTin == id);
            if (tinTuc == null)
            {
                return NotFound();
            }

            return View(tinTuc);
        }

        // POST: TinTucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tinTuc = await _context.TinTucs.FindAsync(id);
            _context.TinTucs.Remove(tinTuc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TinTucExists(int id)
        {
            return _context.TinTucs.Any(e => e.MaTin == id);
        }
    }
}
