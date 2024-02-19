using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblSnapdealProduct1
    {
        public TblSnapdealProduct1()
        {
            TblSnapdealCart1s = new HashSet<TblSnapdealCart1>();
            TblSnapdealWishList1s = new HashSet<TblSnapdealWishList1>();
        }

        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCategory { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? ProductDiscount { get; set; }
        public int? ProductQuantity { get; set; }
        public decimal? NewPrice { get; set; }

        public virtual ICollection<TblSnapdealCart1> TblSnapdealCart1s { get; set; }
        public virtual ICollection<TblSnapdealWishList1> TblSnapdealWishList1s { get; set; }
    }
}
