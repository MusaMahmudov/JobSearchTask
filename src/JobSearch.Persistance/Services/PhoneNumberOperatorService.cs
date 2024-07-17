using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.OperatorDTOs;
using JobSearch.Applicationl;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Services;

public class PhoneNumberOperatorService : IPhoneNumberOperatorService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public PhoneNumberOperatorService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<bool> CreateAsync(PostPhoneNumberOperatorDTO postOperatorDTO)
    {
        var newOperator = _mapper.Map<PhoneNumberOperator>(postOperatorDTO);
        
        await _unitOfWork.OperatorWriteRepository.AddAsync(newOperator);
        await _unitOfWork.SaveChangesAsync();
        return true;    
    }
}
