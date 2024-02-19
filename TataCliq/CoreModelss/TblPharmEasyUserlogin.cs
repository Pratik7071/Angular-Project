using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblPharmEasyUserlogin
    {
        public int UserId { get; set; }
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
    }
}
