using System.Collections.Generic;

namespace RHPsicotest.WebSite.DTOs
{
    public class CandidateLoginDTO
    {
        public int IdCandidate { get; set; }

        public string Email { get; set; }

        public string RoleName { get; set; }

        public string PositionName { get; set; }

        public bool HasExpediente { get; set; }

        public List<string> Permissions{ get; set; }
    }
}
