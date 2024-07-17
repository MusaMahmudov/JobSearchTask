using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.CurrencyDTO;
using JobSearch.Applicationl;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Services;

public class CurrencyService : ICurrencyService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CurrencyService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _mapper= mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> CreateAsync(PostCurrencyDTO postCurrencyDTO)
    {
        var newCurrency = _mapper.Map<Currency>(postCurrencyDTO);

       var result = await _unitOfWork.CurrencyWriteRepository.AddAsync(newCurrency);
        await _unitOfWork.SaveChangesAsync(); 
        return result;
    }
}
