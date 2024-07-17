using AutoMapper;
using JobSearch.Application.DTOs.OperatorDTOs;
using JobSearch.Application.Features.Commands.Operator.Post;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Mappers;

public class PhoneNumberOperatorMapper : Profile
{
    public PhoneNumberOperatorMapper()
    {
        CreateMap<PostPhoneNumberOperatorCommandRequest,PostPhoneNumberOperatorDTO>().ReverseMap();
        CreateMap<PostPhoneNumberOperatorDTO, PhoneNumberOperator>().ReverseMap();
    }
}
