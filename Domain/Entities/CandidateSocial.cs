using Domain.Entities.Setup;

namespace Domain.Entities
{
    public class CandidateSocial : BaseEntity
    {
        public string Path { get; set; }

        public int SocialNetworkId { get; set; }
        public virtual SocialNetwork SocialNetwork { get; set; }

        public int CandidateId { get; set; }
        public virtual Candidate Candidate { get; set; }
    }
}