using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class QuizModel
    {
        public int QuizId { get; set; }
        public string QuestionText { get; set; } = null!;
        public int AssessmentId { get; set; }
        public string Option1 { get; set; } = null!;
        public string Option2 { get; set; } = null!;
        public string Option3 { get; set; } = null!;
        public string Option4 { get; set; } = null!;
        public string CorrectOption { get; set; } = null!;

        public virtual Assessment Assessment { get; set; } = null!;
    }
}
