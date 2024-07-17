using AutoMapper;
using JobSearch.Application.DTOs.SalaryTypeDTOs;
using JobSearch.Application.Features.Commands.SalaryType.Post;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Mappers;

public class SalaryTypeMapper : Profile
{
    public SalaryTypeMapper()
    {
        CreateMap<PostSalaryTypeCommandRequest,PostSalaryTypeDTO>();
        CreateMap<PostSalaryTypeDTO,SalaryType>();
    }
}
