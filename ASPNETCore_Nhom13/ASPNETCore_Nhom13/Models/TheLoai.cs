using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCore_Nhom13.Models
{
    public class TheLoai
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaTheLoai { get; set; }
        [Required]
        [MaxLength(50)]
        public string TenTheLoai { get; set; }
    }
}
