﻿using DAL;
using DAL.DTO;
using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseOfTalents.DAL.Services
{
    public class VacancyService
    {
        IUnitOfWork uow;

        public VacancyService()
        {
            this.uow = new UnitOfWork();
        }

        public VacancyService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public IEnumerable<VacancyDTO> Get(int page, int pageSize)
        {
            return uow.VacancyRepo.Get(page: page, pageSize: pageSize)
                .Select(vacancy => 
                    new VacancyDTO
                    {
                        CandidatesProgress = vacancy.CandidatesProgress,
                        Comments = vacancy.Comments,
                        DeadlineDate = vacancy.DeadlineDate,
                        Department = vacancy.Department,
                        Description = vacancy.Description,
                        EndDate = vacancy.EndDate,
                        Files = vacancy.Files,
                        Industry = vacancy.Industry,
                        LanguageSkill = vacancy.LanguageSkill,
                        Levels = vacancy.Levels,
                        Locations = vacancy.Locations,
                        ParentVacancy = vacancy.ParentVacancy,
                        RequiredSkills = vacancy.RequiredSkills,
                        Responsible = vacancy.Responsible,
                        SalaryMax = vacancy.SalaryMax,
                        SalaryMin = vacancy.SalaryMin,
                        StartDate = vacancy.StartDate,
                        Tags = vacancy.Tags,
                        Title = vacancy.Title,
                        TypeOfEmployment = vacancy.TypeOfEmployment
                    }
                );
        }
    }
}