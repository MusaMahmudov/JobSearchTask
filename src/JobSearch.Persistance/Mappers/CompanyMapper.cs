using AutoMapper;
using JobSearch.Application.DTOs.CompanyDTOs;
using JobSearch.Application.Features.Commands.Company.PostCompany;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Mappers;

public class CompanyMapper : Profile
{
    public CompanyMapper()
    {
        CreateMap<PostCompanyDTO,Company>().ReverseMap();
        CreateMap<PostCompanyCommandRequest,PostCompanyDTO>().ReverseMap(); 
    }
}
