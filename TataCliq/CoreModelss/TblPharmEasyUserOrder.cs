using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblPharmEasyUserOrder
    {
        public TblPharmEasyUserOrder()
        {
            TblPharmEasyUserOrderItems = new HashSet<TblPharmEasyUserOrderItem>();
        }

        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public virtual TblPharmEasyUser? User { get; set; }
        public virtual ICollection<TblPharmEasyUserOrderItem> TblPharmEasyUserOrderItems { get; set; }
    }
}
