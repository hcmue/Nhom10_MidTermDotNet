using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom10_MidTermDotNet.Models
{
    public class MonHoc
    {
        [Key]
        [Display(Name = "Mã Môn Học")]
        public int MaMon { get; set; }

        [Display(Name = "Tên Môn Học")]
        public string TenMon { get; set; }

        [Display(Name = "Số Tín Chỉ")]
        [Range(1,5)]
        public int SoTinChi { get; set; }

        
    }
}
