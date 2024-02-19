using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblPharmEasyPincode
    {
        public TblPharmEasyPincode()
        {
            TblPharmEasyProds = new HashSet<TblPharmEasyProd>();
            TblPharmEasyStores = new HashSet<TblPharmEasyStore>();
        }

        public int IId { get; set; }
        public int IPincodeId { get; set; }
        public int? IPincode { get; set; }
        public int? ILocationId { get; set; }

        public virtual TblPharmEasyLocation? ILocation { get; set; }
        public virtual ICollection<TblPharmEasyProd> TblPharmEasyProds { get; set; }
        public virtual ICollection<TblPharmEasyStore> TblPharmEasyStores { get; set; }
    }
}
