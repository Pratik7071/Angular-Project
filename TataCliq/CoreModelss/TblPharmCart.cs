using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblPharmCart
    {
        public int ICartId { get; set; }
        public int IProductId { get; set; }
        public string? VProductName { get; set; }
        public string? VProductDescription { get; set; }
        public string? VManufacturer { get; set; }
        public decimal? DeProductPrice { get; set; }
        public int? IQuantity { get; set; }
        public string? VImageUrl { get; set; }

        public virtual TblPharmProduct IProduct { get; set; } = null!;
    }
}
