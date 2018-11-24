using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom10_MidTermDotNet.Models
{
    public class MyDBContext : DbContext
    {
        public DbSet<Khoa> Khoa { get; set; }
        public DbSet<SinhVien> SinhVien { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<KetQua> KetQua { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { optionsBuilder.UseSqlServer(@"Server=.;Database=QLSinhVien;Integrated Security=True;"); }
    }
}
