using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblTataCliqUser
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? UserTypeId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual TblTataCliqUserType? UserType { get; set; }
    }
}
