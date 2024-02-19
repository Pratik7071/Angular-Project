using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblTataCliqBrand
    {
        public TblTataCliqBrand()
        {
            TblTataCliqProducts = new HashSet<TblTataCliqProduct>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<TblTataCliqProduct> TblTataCliqProducts { get; set; }
    }
}
