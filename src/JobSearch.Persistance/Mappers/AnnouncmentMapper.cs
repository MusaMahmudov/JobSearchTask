using AutoMapper;
using JobSearch.Application.DTOs.AnnouncmentDTOs;
using JobSearch.Application.Features.Commands.Announcment.Post;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Mappers;

public class AnnouncmentMapper : Profile
{
    public AnnouncmentMapper() 
    {
        CreateMap<Announcment, GetAnnouncmentDTO>().ForMember(ga=>ga.Requirements,x=>x.MapFrom(a=> a.Requirements != null ? a.Requirements.Select(r=>r.Description) : null)).ForMember(ga=>ga.CompanyName,x=>x.MapFrom(a=>a.Company.Name)).ForMember(ga => ga.CategoryName, x => x.MapFrom(a => a.Category.Name)).ForMember(ga => ga.JobTypeName, x => x.MapFrom(a=>a.JobType.Name)).ReverseMap();


        CreateMap<PostAnnouncmentCommandRequest,PostAnnouncmentDTO>().ReverseMap();
        CreateMap<PostAnnouncmentDTO,Announcment>().ReverseMap();
    }
}
