using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {
        public long ID { get; set; }
        [Key]
        public string MSNV { get; set; }
        public string TenNV { get; set; }

    }
}
