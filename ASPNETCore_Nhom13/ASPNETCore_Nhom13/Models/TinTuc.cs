using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETCore_Nhom13.Models
{
    public class TinTuc
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaTin { get; set; }
        [Required]
        [MaxLength(50)]
        public string TieuDe { get; set; }
        [Required]
        public string NoiDung { get; set; }
        [Required]
        public string Hinh { get; set; }
        [Required]
        public DateTime NgayDang { get; set; }

        public int MaTheLoai { get; set; }
        [ForeignKey("MaTheLoai")]
        public TheLoai TheLoai { get; set; }

        public int MaNguoiDung { get; set; }
        [ForeignKey("MaNguoiDung")]
        //public NguoiDung NguoiDung { get; set; }

        public bool TrangThai { get; set; }

    }
}
