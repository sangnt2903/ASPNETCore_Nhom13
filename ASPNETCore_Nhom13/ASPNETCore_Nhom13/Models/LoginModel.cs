using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ASPNETCore_Nhom13.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Vui lòng nhập tài khoản")]
        public string Email { set; get; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string matKhau { set; get; }
        
    }
}
