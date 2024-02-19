using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblTataCliqCategory
    {
        public TblTataCliqCategory()
        {
            TblTataCliqProducts = new HashSet<TblTataCliqProduct>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<TblTataCliqProduct> TblTataCliqProducts { get; set; }
    }
}
