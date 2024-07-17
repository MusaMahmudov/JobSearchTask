using AutoMapper;
using JobSearch.Application.DTOs.JobLocationDTO;
using JobSearch.Application.Features.Commands.JobLocation.Post;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Mappers;

public class JobLocationMapper : Profile
{
    public JobLocationMapper() 
    {
        CreateMap<PostJobLocationDTO,JobLocation>().ReverseMap();
        CreateMap<PostJobLocationCommandRequest,PostJobLocationDTO>().ReverseMap();
    }
}
