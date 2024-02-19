using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblOnlineAssessmentAssessmentResult
    {
        public int IdAssessmentResult { get; set; }
        public int AssessmentResultId { get; set; }
        public int? QuizId { get; set; }
        public int Score { get; set; }
        public string PassOrFail { get; set; } = null!;
        public int? UserId { get; set; }

        public virtual TblOnlineAssessmentQuiz? Quiz { get; set; }
        public virtual TblOnlineAssessmentUser? User { get; set; }
    }
}
