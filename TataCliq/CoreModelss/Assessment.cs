using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class Assessment
    {
        public Assessment()
        {
            QuizModels = new HashSet<QuizModel>();
        }

        public int AssessmentId { get; set; }
        public string AssessmentName { get; set; } = null!;
        public string AssessmentDescription { get; set; } = null!;
        public string DifficultyLevel { get; set; } = null!;

        public virtual ICollection<QuizModel> QuizModels { get; set; }
    }
}
