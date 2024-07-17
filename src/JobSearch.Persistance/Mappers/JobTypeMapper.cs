using AutoMapper;
using JobSearch.Application.DTOs.JobTypeDTOs;
using JobSearch.Application.Features.Commands.JobType.Post;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Mappers;

public class JobTypeMapper : Profile
{
    public JobTypeMapper()
    {
        CreateMap<PostJobTypeDTO, JobType>().ReverseMap();
        CreateMap<PostJobTypeCommandRequest,PostJobTypeDTO>().ReverseMap();
    }
}
