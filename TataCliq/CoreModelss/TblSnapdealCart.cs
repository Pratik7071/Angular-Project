using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblSnapdealCart
    {
        public int CId { get; set; }
        public int CartId { get; set; }
        public int? CartQuantity { get; set; }
        public int? ProductId { get; set; }
        public int? FlashSaleId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCategory { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? ProductNewPrice { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TblSnapdealOngoingSale? FlashSale { get; set; }
        public virtual TblSnapdealProduct? Product { get; set; }
    }
}
