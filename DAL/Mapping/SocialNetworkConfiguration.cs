using Domain.Entities.Setup;

namespace Data.EFData.Mapping
{
    public class SocialNetworkConfiguration : BaseEntityConfiguration<SocialNetwork>
    {
        public SocialNetworkConfiguration()
        {
            Property(sn => sn.Title).IsRequired();
            Property(sn => sn.ImagePath).IsRequired();

            HasMany(x => x.CandidateSocials).WithRequired(x => x.SocialNetwork).HasForeignKey(x => x.SocialNetworkId);
        }
    }
}