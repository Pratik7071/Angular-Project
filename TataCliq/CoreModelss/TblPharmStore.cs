using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblPharmStore
    {
        public int? IStoreId { get; set; }
        public int? IProductId { get; set; }
        public string? VStoreName { get; set; }
        public string? VStoreLocation { get; set; }
        public int? IStorePincode { get; set; }

        public virtual TblPharmProduct? IProduct { get; set; }
    }
}
