using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext>options):base(options)
        {
                
        }
        DbSet<NhanVien> NhanViens { get; set; }
        DbSet<TaiKhoan> TaiKhoans { get; set; }
    }
}
