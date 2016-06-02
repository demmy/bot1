using Domain.Entities.Setup;

namespace Data.EFData.Mapping
{
    public class SkillConfiguration : BaseEntityConfiguration<Skill>
    {
        public SkillConfiguration()
        {
            Property(s => s.Title);
        }
    }
}