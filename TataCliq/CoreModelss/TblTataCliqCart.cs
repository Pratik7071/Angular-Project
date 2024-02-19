using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblTataCliqCart
    {
        public TblTataCliqCart()
        {
            TblTataCliqOrders = new HashSet<TblTataCliqOrder>();
        }

        public int CartId { get; set; }
        public bool IsDeleted { get; set; }
        public int? ProductId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual TblTataCliqProduct? Product { get; set; }
        public virtual ICollection<TblTataCliqOrder> TblTataCliqOrders { get; set; }
    }
}
