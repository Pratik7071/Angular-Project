using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblOnlineAssesmentUserResponse
    {
        public int IdUserResponse { get; set; }
        public int UserResponseId { get; set; }
        public int SelectedAnswerIndex { get; set; }
        public int? UserId { get; set; }
        public int? QuestionId { get; set; }

        public virtual TblOnlineAssesmentQuestion? Question { get; set; }
        public virtual TblOnlineAssessmentUser? User { get; set; }
    }
}
