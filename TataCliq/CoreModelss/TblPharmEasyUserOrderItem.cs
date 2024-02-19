using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblPharmEasyUserOrderItem
    {
        public int OrderItemId { get; set; }
        public int? OrderId { get; set; }
        public int? IProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual TblPharmEasyUserProduct? IProduct { get; set; }
        public virtual TblPharmEasyUserOrder? Order { get; set; }
    }
}
