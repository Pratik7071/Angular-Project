using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblGoibiboHoliday
    {
        public int HId { get; set; }
        public int HolidayId { get; set; }
        public string? Category { get; set; }
        public string? Destination { get; set; }
        public int? Budget { get; set; }
        public int? Duration { get; set; }
        public string? ImgUrl { get; set; }
    }
}
