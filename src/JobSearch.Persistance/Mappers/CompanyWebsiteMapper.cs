using AutoMapper;
using JobSearch.Application.DTOs.CompanyWebsiteDTOs;
using JobSearch.Application.Features.Commands.CompanyWebsite.PostCompanyWebsite;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Mappers;

public class CompanyWebsiteMapper : Profile
{
    public CompanyWebsiteMapper()
    {
        CreateMap<PostCompanyWebsiteDTO,CompanyWebsite>();
        CreateMap<PostCompanyWebsiteCommandRequest,PostCompanyWebsiteDTO>();
    }
}
