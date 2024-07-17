using AutoMapper;
using JobSearch.Application.DTOs.RequirementDTOs;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Mappers
{
    public class RequirementMapper : Profile
    {
        public RequirementMapper()
        {
            CreateMap<PostRequirementDTO, Requirements>().ReverseMap();
            CreateMap<PostRequirementForAnnouncmentDTO, Requirements>().ReverseMap();
        }
    }
}
