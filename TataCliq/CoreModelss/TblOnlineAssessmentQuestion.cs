using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblOnlineAssessmentQuestion
    {
        public int QuestionId { get; set; }
        public string? QuestionText { get; set; }
        public string? Choice1 { get; set; }
        public string? Choice2 { get; set; }
        public string? Choice3 { get; set; }
        public string? Choice4 { get; set; }
        public int? CorrectChoice { get; set; }
        public int? QuizId { get; set; }

        public virtual TblOnlineAssessmentQuiz1? Quiz { get; set; }
    }
}
