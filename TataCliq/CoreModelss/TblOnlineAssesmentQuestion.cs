using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblOnlineAssesmentQuestion
    {
        public TblOnlineAssesmentQuestion()
        {
            TblOnlineAssesmentUserResponses = new HashSet<TblOnlineAssesmentUserResponse>();
        }

        public int IdQuestion { get; set; }
        public int QuestionId { get; set; }
        public int? QuizId { get; set; }
        public string QuestionText { get; set; } = null!;
        public string Option1 { get; set; } = null!;
        public string Option2 { get; set; } = null!;
        public string Option3 { get; set; } = null!;
        public string Option4 { get; set; } = null!;
        public int? CorrectOption { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TblOnlineAssessmentQuiz? Quiz { get; set; }
        public virtual ICollection<TblOnlineAssesmentUserResponse> TblOnlineAssesmentUserResponses { get; set; }
    }
}
