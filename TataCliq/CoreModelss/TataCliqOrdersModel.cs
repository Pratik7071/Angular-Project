using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModelss
{
    public class TataCliqOrdersModel
    {
        public List<ProductModel> Products { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ModeOfPayment { get; set; }

        public int ShopAddressId { get; set; }
    }
    public class ProductModel
    {
        public int CartId { get; set; }
        public int OrderQuantity { get; set; }
    }
}
