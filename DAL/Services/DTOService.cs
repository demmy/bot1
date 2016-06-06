﻿using AutoMapper;
using BaseOfTalents.Domain.Entities;
using Domain.DTO.DTOModels;
using Domain.Entities;

namespace DAL.Services
{
    public static class DTOService
    {
        public static DTO ToDTO<DomainEntity, DTO>(DomainEntity entity)
            where DomainEntity :    BaseEntity,     new()
            where DTO :             BaseEntityDTO,  new()
        {
            return Mapper.Map<DomainEntity, DTO>(entity);
        }

        public static ViewModel ToViewModel<DTO, ViewModel>(DTO entity)
            where DTO :             BaseEntityDTO,  new()
            where ViewModel :                       new()
        {
            return Mapper.Map<DTO, ViewModel>(entity);
        }
    }
}
