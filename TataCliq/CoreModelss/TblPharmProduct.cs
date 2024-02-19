using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblPharmProduct
    {
        public TblPharmProduct()
        {
            TblPharmOtherDetails = new HashSet<TblPharmOtherDetail>();
        }

        public int IId { get; set; }
        public int IProductId { get; set; }
        public string? VProductName { get; set; }
        public string? VProductDescription { get; set; }
        public string? VManufacturer { get; set; }
        public DateTime? DExpiryDate { get; set; }
        public decimal? DeProductPrice { get; set; }
        public int? IQuantity { get; set; }
        public string? VImageUrl { get; set; }
        public bool? BIsactive { get; set; }

        public virtual TblPharmCart? TblPharmCart { get; set; }
        public virtual ICollection<TblPharmOtherDetail> TblPharmOtherDetails { get; set; }
    }
}
