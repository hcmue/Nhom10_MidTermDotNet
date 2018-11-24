using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom10_MidTermDotNet.Models
{
    public class Khoa
    {
        [Key]
        [Display(Name = "Mã Khoa")]
        public int MaKhoa { get; set; }
        
        [Display(Name = "Tên Khoa")]
        public string TenKhoa { get; set; }
        
    }
}
