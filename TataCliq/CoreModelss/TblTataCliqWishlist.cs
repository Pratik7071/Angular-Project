using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblTataCliqWishlist
    {
        public int WishListId { get; set; }
        public int ProductId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual TblTataCliqProduct Product { get; set; } = null!;
    }
}
