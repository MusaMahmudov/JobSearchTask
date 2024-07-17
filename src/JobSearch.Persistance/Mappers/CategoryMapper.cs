using AutoMapper;
using JobSearch.Application.DTOs.Category;
using JobSearch.Application.Features.Commands.Category.Post;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Mappers;

public class CategoryMapper : Profile
{ 
    public CategoryMapper()
    {
        CreateMap<PostCategoryDTO,Category>().ReverseMap();
        CreateMap<PostCategoryCommandRequest,PostCategoryDTO>().ReverseMap();
    }
}
