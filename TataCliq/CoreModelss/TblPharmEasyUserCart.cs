using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblPharmEasyUserCart
    {
        public int CartId { get; set; }
        public int? UserId { get; set; }
        public int? IProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual TblPharmEasyUserProduct? IProduct { get; set; }
        public virtual TblPharmEasyUser? User { get; set; }
    }
}
