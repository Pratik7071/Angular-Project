using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblOnlineAssesmentCategory
    {
        public TblOnlineAssesmentCategory()
        {
            TblAssessmentQuizTools = new HashSet<TblAssessmentQuizTool>();
            TblOnlineAssessmentQuizzes = new HashSet<TblOnlineAssessmentQuiz>();
        }

        public int CatId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<TblAssessmentQuizTool> TblAssessmentQuizTools { get; set; }
        public virtual ICollection<TblOnlineAssessmentQuiz> TblOnlineAssessmentQuizzes { get; set; }
    }
}
