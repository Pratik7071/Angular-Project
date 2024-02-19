using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string ProductDescription { get; set; } = null!;
        public decimal ProductPrice { get; set; }
        public int Availability { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
