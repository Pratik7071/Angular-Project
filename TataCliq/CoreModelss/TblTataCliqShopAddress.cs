using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblTataCliqShopAddress
    {
        public TblTataCliqShopAddress()
        {
            TblTataCliqOrders = new HashSet<TblTataCliqOrder>();
        }

        public int ShopAddressId { get; set; }
        public int Pincode { get; set; }
        public string? ShopAddress { get; set; }
        public string? ShopName { get; set; }

        public virtual ICollection<TblTataCliqOrder> TblTataCliqOrders { get; set; }
    }
}
