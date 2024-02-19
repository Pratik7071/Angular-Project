using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblOnlineAssesmentInstructor
    {
        public TblOnlineAssesmentInstructor()
        {
            TblAssessmentQuizTools = new HashSet<TblAssessmentQuizTool>();
            TblOnlineAssessmentQuizzes = new HashSet<TblOnlineAssessmentQuiz>();
        }

        public int InsturctId { get; set; }
        public int InstructorId { get; set; }
        public string InstructorName { get; set; } = null!;

        public virtual ICollection<TblAssessmentQuizTool> TblAssessmentQuizTools { get; set; }
        public virtual ICollection<TblOnlineAssessmentQuiz> TblOnlineAssessmentQuizzes { get; set; }
    }
}
