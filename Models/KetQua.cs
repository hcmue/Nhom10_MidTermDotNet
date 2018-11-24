using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom10_MidTermDotNet.Models
{
    public class KetQua
    {
        [Display(Name = "Mã Kết Quả")]
        [Key]
        public int MaKetQua { get; set; }

        [ForeignKey("MaMon")]
        [Display(Name = "Mã Môn Học")]
        public int MaMon { get; set; }


        [ForeignKey("MaSV")]
        [Display(Name = "Mã Sinh Viên")]
        public int MaSV { get; set; }
    }
}
