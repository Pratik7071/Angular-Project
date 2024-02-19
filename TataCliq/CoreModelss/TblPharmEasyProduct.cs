using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblPharmEasyProduct
    {
        public int IId { get; set; }
        public int IProductId { get; set; }
        public string? VProductName { get; set; }
        public string? VProductDescription { get; set; }
        public string? VManufacturer { get; set; }
        public decimal? DeProductPrice { get; set; }
        public int? IQuantity { get; set; }
        public string? VImageUrl { get; set; }
        public DateTime? DExpiryDate { get; set; }
        public string? VComposition { get; set; }
        public string? VUses { get; set; }
        public string? VSideEffects { get; set; }
        public string? VWarnings { get; set; }
        public string? VStoreName { get; set; }
        public string? VStoreLocation { get; set; }
        public int? IStorePincode { get; set; }
        public bool? BIsActive { get; set; }
    }
}
