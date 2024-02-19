using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class ItenaryDetail
    {
        public int? Itinaryid { get; set; }
        public int? Daysnum { get; set; }
        public string? Daytitle { get; set; }
        public string? Morning { get; set; }
        public string? Afternoon { get; set; }
        public string? Evening { get; set; }
        public string? Location1 { get; set; }
        public string? Location2 { get; set; }

        public virtual GoibiboItinery? Itinary { get; set; }
    }
}
