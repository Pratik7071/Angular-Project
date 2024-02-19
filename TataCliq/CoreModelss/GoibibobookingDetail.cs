using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class GoibibobookingDetail
    {
        public int TblId { get; set; }
        public int HotelId { get; set; }
        public DateTime BookingFromDate { get; set; }
        public DateTime BookingEndDate { get; set; }
        public int RoomsCount { get; set; }
    }
}
