using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom10_MidTermDotNet.Models
{
    public class SinhVien
    {
        [Key]
        [Display(Name = "Mã sinh viên")]
        public int MaSV { get; set; }

        [Display(Name = "Họ Tên Sinh Viên")]
        [MinLength(2, ErrorMessage = "Tối thiểu 2 ký tự")]
        [StringLength(100)]
        public string HoTen { get; set; }

        [DataType(DataType.Date)]
        [BirthDateCheck]
        [Display(Name = "Ngày sinh")]
        public DateTime NgaySinh { get; set; }

        
    }

    public class BirthDateCheckAttribute : ValidationAttribute
    {
        public BirthDateCheckAttribute() : base("Ngày sinh không hợp lệ") { }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = validationContext.ObjectInstance as SinhVien; if (model == null)
            { throw new ArgumentException("Tham số truyền không đúng"); }
            if (DateTime.Now.Year - model.NgaySinh.Year < 18) { return new ValidationResult("Chưa đủ 18 tuổi"); }
            return ValidationResult.Success;
        }
    }
}

