using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtApiSimple.Models
{
    public class LoginRequest
    {
        /// <summary>
        /// Tên đăng nhập
        /// </summary>
        /// <example>DTT</example>
        public string UserName { get; set; }
        /// <summary>
        /// Mật khẩu
        /// </summary>
        /// <example>DTT@123</example>
        public string Password { get; set; }
    }
}
