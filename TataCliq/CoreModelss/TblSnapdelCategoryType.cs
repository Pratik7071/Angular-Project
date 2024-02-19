using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblSnapdelCategoryType
    {
        public TblSnapdelCategoryType()
        {
            TblSnapdealProducts = new HashSet<TblSnapdealProduct>();
            TblSnapdelCategories = new HashSet<TblSnapdelCategory>();
        }

        public int CtId { get; set; }
        public int CategorytypeId { get; set; }
        public string? CategorytypeName { get; set; }
        public int? TopCategoryId { get; set; }

        public virtual TblSnapdelTopCategory? TopCategory { get; set; }
        public virtual ICollection<TblSnapdealProduct> TblSnapdealProducts { get; set; }
        public virtual ICollection<TblSnapdelCategory> TblSnapdelCategories { get; set; }
    }
}
