using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETCore_Nhom13.Models
{
    public class NguoiDung
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaNguoiDung { get; set; }
        [Required]
        public string HoTen { get; set; }
        [Required]
        public string MatKhau { get; set; }
    }
}
