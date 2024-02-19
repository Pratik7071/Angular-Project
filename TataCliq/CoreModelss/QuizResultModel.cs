using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class QuizResultModel
    {
        public int ResultId { get; set; }
        public string UserResponse { get; set; } = null!;
        public int Score { get; set; }
        public int TotalQuestions { get; set; }
    }
}
