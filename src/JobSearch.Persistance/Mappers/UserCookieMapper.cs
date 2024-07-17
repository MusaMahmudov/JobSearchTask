using AutoMapper;
using JobSearch.Application.DTOs.CookieDTOs;
using JobSearch.Application.Features.Commands.UserCookie.Post;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Mappers;

public class UserCookieMapper : Profile
{
    public UserCookieMapper()
    {
        CreateMap<PostUserCookieCommandRequest, PostUserCookieDTO>().ReverseMap();
        CreateMap<PostUserCookieDTO, UserCookies>().ReverseMap();
    }
}
