using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class GoIbIboRole
    {
        public GoIbIboRole()
        {
            GoibiboUsers = new HashSet<GoibiboUser>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;

        public virtual ICollection<GoibiboUser> GoibiboUsers { get; set; }
    }
}
