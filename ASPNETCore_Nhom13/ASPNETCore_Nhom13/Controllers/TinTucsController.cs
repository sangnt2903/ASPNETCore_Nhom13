using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPNETCore_Nhom13.Models;
using Microsoft.AspNetCore.Http;

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
        public async Task<IActionResult> Index()
        {
            List<TinTuc> dsTin = new List<TinTuc>();
            if (HttpContext.Session.Get("admin") != null)
            {
                dsTin = _context.TinTucs.OrderBy(p => p.NgayDang).ToList();
            }
            var myDbContext = _context.TinTucs.Include(t => t.NguoiDung).Include(t => t.TheLoai);
            return View(await myDbContext.ToListAsync());
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
            ViewData["MaNguoiDung"] = new SelectList(_context.NguoiDungs, "MaNguoiDung", "HoTen");
            ViewData["MaTheLoai"] = new SelectList(_context.TheLoais, "MaTheLoai", "TenTheLoai");
            return View();
        }

        // POST: TinTucs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaTin,TieuDe,NoiDung,Hinh,NgayDang,MaTheLoai,MaNguoiDung")] TinTuc tinTuc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tinTuc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
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
