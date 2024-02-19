using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblSnapdelCategory
    {
        public TblSnapdelCategory()
        {
            TblSnapdealOngoingSales = new HashSet<TblSnapdealOngoingSale>();
            TblSnapdealSubcategories = new HashSet<TblSnapdealSubcategory>();
            TblSnapdealWishlistNews = new HashSet<TblSnapdealWishlistNew>();
            TblSnapdealWishlists = new HashSet<TblSnapdealWishlist>();
        }

        public int CId { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int? CategorytypeId { get; set; }

        public virtual TblSnapdelCategoryType? Categorytype { get; set; }
        public virtual ICollection<TblSnapdealOngoingSale> TblSnapdealOngoingSales { get; set; }
        public virtual ICollection<TblSnapdealSubcategory> TblSnapdealSubcategories { get; set; }
        public virtual ICollection<TblSnapdealWishlistNew> TblSnapdealWishlistNews { get; set; }
        public virtual ICollection<TblSnapdealWishlist> TblSnapdealWishlists { get; set; }
    }
}
