using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblGoibiboFlightCustomer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustomerEmail { get; set; } = null!;
        public string CustomerMobile { get; set; } = null!;
    }
}
