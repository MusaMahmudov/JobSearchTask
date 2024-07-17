using AutoMapper;
using JobSearch.Application.DTOs.CurrencyDTO;
using JobSearch.Application.Features.Commands.Currency.Post;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Mappers;

public class CurrencyMapper : Profile
{
    public CurrencyMapper()
    {
        CreateMap<PostCurrencyDTO,Currency>().ReverseMap();
        CreateMap<PostCurrencyCommandRequest,PostCurrencyDTO>().ReverseMap();
    }

}
