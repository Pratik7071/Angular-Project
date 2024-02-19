using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblSnapdealOngoingSale
    {
        public TblSnapdealOngoingSale()
        {
            TblSnapdealCarts = new HashSet<TblSnapdealCart>();
            TblSnapdealWishlistNews = new HashSet<TblSnapdealWishlistNew>();
            TblSnapdealWishlists = new HashSet<TblSnapdealWishlist>();
        }

        public int FId { get; set; }
        public int FlashSaleId { get; set; }
        public int? ProductId { get; set; }
        public string? SaleDate { get; set; }
        public string? SaleStartTime { get; set; }
        public string? SaleEndTime { get; set; }
        public int? StockQuantity { get; set; }
        public decimal? FlashSalePrice { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCategory { get; set; }
        public string? ProductDescription { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? ProductNewPrice { get; set; }
        public int? CategoryId { get; set; }
        public int? SubcategoryId { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Discount { get; set; }

        public virtual TblSnapdelCategory? Category { get; set; }
        public virtual TblSnapdealProduct? Product { get; set; }
        public virtual TblSnapdealSubcategory? Subcategory { get; set; }
        public virtual ICollection<TblSnapdealCart> TblSnapdealCarts { get; set; }
        public virtual ICollection<TblSnapdealWishlistNew> TblSnapdealWishlistNews { get; set; }
        public virtual ICollection<TblSnapdealWishlist> TblSnapdealWishlists { get; set; }
    }
}
