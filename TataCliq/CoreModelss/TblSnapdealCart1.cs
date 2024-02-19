using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblSnapdealCart1
    {
        public int CartId { get; set; }
        public int? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCategory { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? ProductDiscount { get; set; }
        public int? UsaleId { get; set; }
        public int? CartQuantity { get; set; }

        public virtual TblSnapdealProduct1? Product { get; set; }
        public virtual TblUpcomingSale? Usale { get; set; }
    }
}
