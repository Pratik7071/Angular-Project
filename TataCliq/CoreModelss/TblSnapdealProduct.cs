using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblSnapdealProduct
    {
        public TblSnapdealProduct()
        {
            TblSnapdealCarts = new HashSet<TblSnapdealCart>();
            TblSnapdealMyOrders = new HashSet<TblSnapdealMyOrder>();
            TblSnapdealOngoingSales = new HashSet<TblSnapdealOngoingSale>();
            TblSnapdealRatings = new HashSet<TblSnapdealRating>();
            TblSnapdealUpcomingSales = new HashSet<TblSnapdealUpcomingSale>();
            TblSnapdealWishlistNews = new HashSet<TblSnapdealWishlistNew>();
            TblSnapdealWishlists = new HashSet<TblSnapdealWishlist>();
        }

        public int PId { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? ProductNewPrice { get; set; }
        public int? ProductQuantity { get; set; }
        public int? CategoryId { get; set; }
        public int? SubcategoryId { get; set; }
        public int? ProductRating { get; set; }
        public int? ProductReviewCount { get; set; }
        public int? CategorytypeId { get; set; }
        public string? CategorytypeName { get; set; }
        public string? CategoryName { get; set; }
        public string? SubcategoryName { get; set; }
        public int? TopCategoryId { get; set; }
        public string? TopCategoryName { get; set; }

        public virtual TblSnapdelCategoryType? Categorytype { get; set; }
        public virtual TblSnapdelTopCategory? TopCategory { get; set; }
        public virtual ICollection<TblSnapdealCart> TblSnapdealCarts { get; set; }
        public virtual ICollection<TblSnapdealMyOrder> TblSnapdealMyOrders { get; set; }
        public virtual ICollection<TblSnapdealOngoingSale> TblSnapdealOngoingSales { get; set; }
        public virtual ICollection<TblSnapdealRating> TblSnapdealRatings { get; set; }
        public virtual ICollection<TblSnapdealUpcomingSale> TblSnapdealUpcomingSales { get; set; }
        public virtual ICollection<TblSnapdealWishlistNew> TblSnapdealWishlistNews { get; set; }
        public virtual ICollection<TblSnapdealWishlist> TblSnapdealWishlists { get; set; }
    }
}
