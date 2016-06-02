using Domain.Entities;

namespace Data.EFData.Mapping
{
    public class CandidateSourceConfiguration : BaseEntityConfiguration<CandidateSource>
    {
        public CandidateSourceConfiguration()
        {
            Property(sn => sn.Source).IsRequired();
            Property(sn => sn.Path).IsRequired();
        }
    }
}