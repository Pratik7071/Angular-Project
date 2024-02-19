using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class HotelRoom
    {
        public int? HotelId { get; set; }
        public string? HotelImgUrl { get; set; }
        public string? HotelName { get; set; }
        public double? Price { get; set; }
        public string? City { get; set; }
        public int? TotalRooms { get; set; }
    }
}
