using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblSnapdealRating
    {
        public int RId { get; set; }
        public int RatingId { get; set; }
        public int? ProductId { get; set; }
        public int? Rating { get; set; }
        public string? Review { get; set; }

        public virtual TblSnapdealProduct? Product { get; set; }
    }
}
