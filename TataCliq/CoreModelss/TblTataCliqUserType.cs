using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblTataCliqUserType
    {
        public TblTataCliqUserType()
        {
            TblTataCliqUsers = new HashSet<TblTataCliqUser>();
        }

        public int UserTypeId { get; set; }
        public string UserType { get; set; } = null!;
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<TblTataCliqUser> TblTataCliqUsers { get; set; }
    }
}
