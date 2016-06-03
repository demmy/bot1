using BaseOfTalents.Domain.Entities;
using BaseOfTalents.Domain.Entities.Enum;
using BaseOfTalents.Domain.Entities.Enum.Setup;
using System;
using System.Collections.Generic;

namespace BaseOfTalents.DAL.DTO
{
    public class VacancyDTO
    {
        public VacancyDTO()
        {
            Levels = new List<Level>();
            Locations = new List<Location>();
            RequiredSkills = new List<Skill>();
            CandidatesProgress = new List<VacancyStageInfo>();
            Files = new List<File>();
            Comments = new List<Comment>();
            Tags = new List<Tag>();
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public int SalaryMin { get; set; }
        public int SalaryMax { get; set; }
        public TypeOfEmployment? TypeOfEmployment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DeadlineDate { get; set; }

        public IEnumerable<Level> Levels { get; set; }
        public IEnumerable<Location> Locations { get; set; }
        public IEnumerable<Skill> RequiredSkills { get; set; }
        public IEnumerable<VacancyStageInfo> CandidatesProgress { get; set; }
        public IEnumerable<File> Files { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Tag> Tags { get; set; }

        public Vacancy ParentVacancy { get; set; }

        public Industry Industry { get; set; }

        public Department Department { get; set; }

        public User Responsible { get; set; }

        public LanguageSkill LanguageSkill { get; set; }
    }
}