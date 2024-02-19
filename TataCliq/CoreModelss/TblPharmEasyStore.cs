using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblPharmEasyStore
    {
        public TblPharmEasyStore()
        {
            TblPharmEasyProds = new HashSet<TblPharmEasyProd>();
        }

        public int IId { get; set; }
        public int IStoreId { get; set; }
        public string? VStoreName { get; set; }
        public int? IPincodeId { get; set; }

        public virtual TblPharmEasyPincode? IPincode { get; set; }
        public virtual ICollection<TblPharmEasyProd> TblPharmEasyProds { get; set; }
    }
}
