using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class GoibiboUser
    {
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Pwd { get; set; }
        public int? RoleId { get; set; }

        public virtual GoIbIboRole? Role { get; set; }
    }
}
