using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblPharmEasyUsersignin
    {
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public DateTime? RegistrationDate { get; set; }
    }
}
