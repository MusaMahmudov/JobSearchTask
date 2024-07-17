using AutoMapper;
using JobSearch.Application.DTOs.PositionGradeDTOs;
using JobSearch.Application.Features.Commands.PositionGrade.Post;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Mappers;

public class PositionGradeMapper : Profile
{
    public PositionGradeMapper() 
    {
        CreateMap<PostPositionGradeCommandRequest,PostPositionGradeDTO>().ReverseMap();
        CreateMap<PostPositionGradeDTO,PositionGrade>().ReverseMap();
    }
}
