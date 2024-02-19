using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblSnapdealWishList1
    {
        public int WishListId { get; set; }
        public int? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCategory { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? NewPrice { get; set; }

        public virtual TblSnapdealProduct1? Product { get; set; }
    }
}
