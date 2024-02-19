using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblSnapdealUpcomingSale
    {
        public int UId { get; set; }
        public int UpcomingSaleId { get; set; }
        public int? ProductId { get; set; }
        public string? SaleDate { get; set; }
        public string? SaleStartTime { get; set; }
        public string? SaleEndTime { get; set; }
        public decimal? UpcomingPrice { get; set; }
        public string? ProductName { get; set; }
        public decimal? ProductPrice { get; set; }

        public virtual TblSnapdealProduct? Product { get; set; }
    }
}
