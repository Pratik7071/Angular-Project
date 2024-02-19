using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblOnlineAssessmentQuiz
    {
        public TblOnlineAssessmentQuiz()
        {
            TblOnlineAssesmentQuestions = new HashSet<TblOnlineAssesmentQuestion>();
            TblOnlineAssessmentAssessmentResults = new HashSet<TblOnlineAssessmentAssessmentResult>();
        }

        public int IdQuiz { get; set; }
        public int QuizId { get; set; }
        public string QuizName { get; set; } = null!;
        public int? InstructorId { get; set; }
        public int? CategoryId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TblOnlineAssesmentCategory? Category { get; set; }
        public virtual TblOnlineAssesmentInstructor? Instructor { get; set; }
        public virtual ICollection<TblOnlineAssesmentQuestion> TblOnlineAssesmentQuestions { get; set; }
        public virtual ICollection<TblOnlineAssessmentAssessmentResult> TblOnlineAssessmentAssessmentResults { get; set; }
    }
}
