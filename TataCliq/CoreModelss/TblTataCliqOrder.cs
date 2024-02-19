using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblTataCliqOrder
    {
        public int OrderId { get; set; }
        public int? CartId { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string ModeOfPayment { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? OrderQuantity { get; set; }
        public int? ShopAddressId { get; set; }

        public virtual TblTataCliqCart? Cart { get; set; }
        public virtual TblTataCliqShopAddress? ShopAddress { get; set; }
    }
}
