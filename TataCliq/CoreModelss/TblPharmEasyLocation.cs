using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblPharmEasyLocation
    {
        public TblPharmEasyLocation()
        {
            TblPharmEasyPincodes = new HashSet<TblPharmEasyPincode>();
            TblPharmEasyProds = new HashSet<TblPharmEasyProd>();
        }

        public int IId { get; set; }
        public int ILocationId { get; set; }
        public string? VStoreLocation { get; set; }

        public virtual ICollection<TblPharmEasyPincode> TblPharmEasyPincodes { get; set; }
        public virtual ICollection<TblPharmEasyProd> TblPharmEasyProds { get; set; }
    }
}
