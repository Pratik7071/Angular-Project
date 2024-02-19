using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblTataCliqProduct
    {
        public TblTataCliqProduct()
        {
            TblTataCliqCarts = new HashSet<TblTataCliqCart>();
            TblTataCliqWishlists = new HashSet<TblTataCliqWishlist>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? ProductDescription { get; set; }
        public double ActualProductPrice { get; set; }
        public int? DiscountPercentage { get; set; }
        public double FinalProductPrice { get; set; }
        public int StockQuantity { get; set; }
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public double? OldProductPrice { get; set; }
        public DateTime? PriceModifiedTime { get; set; }

        public virtual TblTataCliqBrand? Brand { get; set; }
        public virtual TblTataCliqCategory? Category { get; set; }
        public virtual ICollection<TblTataCliqCart> TblTataCliqCarts { get; set; }
        public virtual ICollection<TblTataCliqWishlist> TblTataCliqWishlists { get; set; }
    }
}
