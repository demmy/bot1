﻿using Domain.Entities;

namespace Data.EFData.Mapping
{
    public class VacancyStageConfiguration : BaseEntityConfiguration<VacancyStage>
    {
        public VacancyStageConfiguration()
        {
            Property(vs => vs.Order).IsRequired();
            Property(vs => vs.IsCommentRequired).IsRequired();
            HasRequired(vs => vs.Stage).WithMany().HasForeignKey(vs => vs.StageId);
        }
    }
}