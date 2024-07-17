using AutoMapper;
using JobSearch.Application.DTOs.CompanyDTOs;
using JobSearch.Application.DTOs.CompanyLocationDTOs;
using JobSearch.Application.Features.Commands.Company.PostCompany;
using JobSearch.Application.Features.Commands.CompanyLocation;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Mappers
{
    public class CompanyLocationMapper : Profile
    {
        public CompanyLocationMapper() 
        {
            CreateMap<PostCompanyLocationCommandRequest, PostCompanyLocationDTO>().ReverseMap();
            CreateMap<PostCompanyLocationDTO, CompanyLocation>().ReverseMap();
        }
    }
}
