using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhamThangWAD.Models
{
    public class Student
    {      
        [Key]
        [Required(ErrorMessage = "Vui lòng nhập mã sinh viên.")]        
        public string MaSinhVien { get; set; }
        public string HinhThuc { get; set; }
        public int SoLuongChongDay { get; set; }
        public int SoLuongTienPhat { get; set; }
        public DateTime NgayNopPhat { get; set; } = DateTime.Now;
    }
}