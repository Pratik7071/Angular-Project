using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblUpcomingSale
    {
        public TblUpcomingSale()
        {
            TblSnapdealCart1s = new HashSet<TblSnapdealCart1>();
        }

        public int UsaleId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCategory { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? ProductDiscount { get; set; }
        public int? ProductQuantity { get; set; }

        public virtual ICollection<TblSnapdealCart1> TblSnapdealCart1s { get; set; }
    }
}
