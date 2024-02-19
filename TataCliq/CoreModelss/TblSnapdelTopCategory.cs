using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblSnapdelTopCategory
    {
        public TblSnapdelTopCategory()
        {
            TblSnapdealProducts = new HashSet<TblSnapdealProduct>();
            TblSnapdelCategoryTypes = new HashSet<TblSnapdelCategoryType>();
        }

        public int TcId { get; set; }
        public int TopCategoryId { get; set; }
        public string? TopCategoryName { get; set; }

        public virtual ICollection<TblSnapdealProduct> TblSnapdealProducts { get; set; }
        public virtual ICollection<TblSnapdelCategoryType> TblSnapdelCategoryTypes { get; set; }
    }
}
