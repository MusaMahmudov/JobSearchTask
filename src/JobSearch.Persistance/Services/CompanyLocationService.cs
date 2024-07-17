using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.CompanyLocationDTOs;
using JobSearch.Applicationl;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Services;

public class CompanyLocationService : ICompanyLocationService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CompanyLocationService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _mapper = mapper;   
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> CreateAsync(PostCompanyLocationDTO postCompanyLocationDTO)
    {
        

        var newCompanylocation = _mapper.Map<CompanyLocation>(postCompanyLocationDTO);

        await _unitOfWork.CompanyLocationWriteRepository.AddAsync(newCompanylocation);
        await _unitOfWork.SaveChangesAsync();

        return true;
    }
}
