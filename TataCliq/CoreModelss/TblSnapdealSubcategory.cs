using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblSnapdealSubcategory
    {
        public TblSnapdealSubcategory()
        {
            TblSnapdealOngoingSales = new HashSet<TblSnapdealOngoingSale>();
            TblSnapdealWishlistNews = new HashSet<TblSnapdealWishlistNew>();
            TblSnapdealWishlists = new HashSet<TblSnapdealWishlist>();
        }

        public int SId { get; set; }
        public int SubcategoryId { get; set; }
        public string? SubcategoryName { get; set; }
        public int? CategoryId { get; set; }

        public virtual TblSnapdelCategory? Category { get; set; }
        public virtual ICollection<TblSnapdealOngoingSale> TblSnapdealOngoingSales { get; set; }
        public virtual ICollection<TblSnapdealWishlistNew> TblSnapdealWishlistNews { get; set; }
        public virtual ICollection<TblSnapdealWishlist> TblSnapdealWishlists { get; set; }
    }
}
