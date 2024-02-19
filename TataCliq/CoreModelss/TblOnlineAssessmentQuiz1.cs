using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblOnlineAssessmentQuiz1
    {
        public TblOnlineAssessmentQuiz1()
        {
            TblOnlineAssessmentQuestions = new HashSet<TblOnlineAssessmentQuestion>();
        }

        public int QuizId { get; set; }
        public string? QuizTitle { get; set; }

        public virtual ICollection<TblOnlineAssessmentQuestion> TblOnlineAssessmentQuestions { get; set; }
    }
}
