using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblSnapdealMyOrder
    {
        public int OId { get; set; }
        public int OrderId { get; set; }
        public int? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCategory { get; set; }
        public string? PurchasedTime { get; set; }
        public string? PurchasedDate { get; set; }
        public bool? IsDelete { get; set; }

        public virtual TblSnapdealProduct? Product { get; set; }
    }
}
