using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblPharmOtherDetail
    {
        public int IOtherDetailsId { get; set; }
        public int? IProductId { get; set; }
        public string? VComposition { get; set; }
        public string? VUses { get; set; }
        public string? VSideEffects { get; set; }
        public string? VWarnings { get; set; }

        public virtual TblPharmProduct? IProduct { get; set; }
    }
}
