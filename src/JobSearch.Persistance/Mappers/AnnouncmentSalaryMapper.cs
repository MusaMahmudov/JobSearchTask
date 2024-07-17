using AutoMapper;
using JobSearch.Application.DTOs.AnnouncmentSalaryDTO;
using JobSearch.Application.Features.Commands.Announcment.Post;
using JobSearch.Application.Features.Commands.AnnouncmentSalary.Post;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Mappers;

public class AnnouncmentSalaryMapper : Profile
{
    public AnnouncmentSalaryMapper() 
    {
        CreateMap<PostAnnouncmentSalaryDTO, AnnouncmentSalary>().ReverseMap();
        CreateMap<PostAnnouncmentSalaryCommandRequest,PostAnnouncmentSalaryDTO>().ReverseMap();

        CreateMap<PostAnnouncmentSalaryForAnnouncmentPostDTO, AnnouncmentSalary>().ReverseMap();

        CreateMap<AnnouncmentSalary, GetAnnoucnemtSalaryForAnnouncmentDTO>().ForMember(ga=>ga.SalaryType,x=>x.MapFrom(a=>a.SalaryType.Name)).ForMember(ga=>ga.CurrencyName,x=>x.MapFrom(a=>a.Currency.Name)).ReverseMap();
    }
}
