using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.SalaryTypeDTOs;
using JobSearch.Applicationl;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Services;

public class SalaryTypeService : ISalaryTypeService
{
    private readonly IUnitOfWork _unitOffWork;
    private readonly IMapper _mapper;
    public SalaryTypeService(IUnitOfWork unitOffWork,IMapper mapper)
    {
        _mapper = mapper;
        _unitOffWork = unitOffWork;
    }

    public async Task<bool> CreateAsync(PostSalaryTypeDTO postSalaryTypeDTO)
    {
        var newSalaryType = _mapper.Map<SalaryType>(postSalaryTypeDTO);
     var result =   await _unitOffWork.SalaryTypeWriteRepository.AddAsync(newSalaryType);
       await _unitOffWork.SaveChangesAsync();
        return result;
    }
}
