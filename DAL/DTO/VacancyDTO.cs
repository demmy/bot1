using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Entities.Enum;
using Domain.Entities.Enum.Setup;

namespace DAL.DTO
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

        public ICollection<Level> Levels { get; set; }
        public ICollection<Location> Locations { get; set; }
        public ICollection<Skill> RequiredSkills { get; set; }
        public ICollection<VacancyStageInfo> CandidatesProgress { get; set; }
        public ICollection<File> Files { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Tag> Tags { get; set; }

        public Vacancy ParentVacancy { get; set; }

        public Industry Industry { get; set; }

        public Department Department { get; set; }

        public User Responsible { get; set; }

        public LanguageSkill LanguageSkill { get; set; }
    }
}