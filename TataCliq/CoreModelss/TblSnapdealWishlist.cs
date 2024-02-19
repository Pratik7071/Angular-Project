using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblSnapdealWishlist
    {
        public int WishlistId { get; set; }
        public int? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCategory { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? ProductNewPrice { get; set; }
        public int? ProductQuantity { get; set; }
        public int? CategoryId { get; set; }
        public int? SubcategoryId { get; set; }
        public int? FlashSaleId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TblSnapdelCategory? Category { get; set; }
        public virtual TblSnapdealOngoingSale? FlashSale { get; set; }
        public virtual TblSnapdealProduct? Product { get; set; }
        public virtual TblSnapdealSubcategory? Subcategory { get; set; }
    }
}
