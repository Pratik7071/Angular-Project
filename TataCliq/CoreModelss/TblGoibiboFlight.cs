using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblGoibiboFlight
    {
        public int FlightId { get; set; }
        public string FlightName { get; set; } = null!;
        public string FlightSource { get; set; } = null!;
        public string FlightDestination { get; set; } = null!;
        public DateTime FlightDate { get; set; }
        public int Price { get; set; }
    }
}
