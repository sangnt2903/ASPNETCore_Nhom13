using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCore_Nhom13.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<TinTuc> TinTucs { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }

        public MyDbContext() { }
        public MyDbContext(DbContextOptions options) : base(options) { }

    }
}
