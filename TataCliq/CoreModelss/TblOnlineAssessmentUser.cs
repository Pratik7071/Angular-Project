using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblOnlineAssessmentUser
    {
        public TblOnlineAssessmentUser()
        {
            TblOnlineAssesmentUserResponses = new HashSet<TblOnlineAssesmentUserResponse>();
            TblOnlineAssessmentAssessmentResults = new HashSet<TblOnlineAssessmentAssessmentResult>();
        }

        public int IdUser { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool? RoleId { get; set; }
        public string? Email { get; set; }
        public long? PhoneNumber { get; set; }

        public virtual ICollection<TblOnlineAssesmentUserResponse> TblOnlineAssesmentUserResponses { get; set; }
        public virtual ICollection<TblOnlineAssessmentAssessmentResult> TblOnlineAssessmentAssessmentResults { get; set; }
    }
}
