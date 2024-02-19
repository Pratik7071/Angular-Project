using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblGoibiboFlightsF
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public string? Operator { get; set; }
        public string? FlightSource { get; set; }
        public string? FlightDestination { get; set; }
        public string? FlightDate { get; set; }
        public string? Time { get; set; }
        public int? Stops { get; set; }
        public int? GeneralPrice { get; set; }
        public int? ArmedForces { get; set; }
        public int? Medical { get; set; }
        public int? Student { get; set; }
        public int? Seniors { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Logo { get; set; }
    }
}
