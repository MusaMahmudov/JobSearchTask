using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.CompanyDTOs;
using JobSearch.Applicationl;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Services;

public class CompanyService : ICompanyService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CompanyService(IUnitOfWork unitOfWork,IMapper mapper)
    {
       _mapper = mapper;
       _unitOfWork = unitOfWork;
    }
    public async Task<bool> CreateAsync(PostCompanyDTO postCompanyDTO)
    {
        var newCompany = _mapper.Map<Company>(postCompanyDTO);

           await _unitOfWork.CompanyWriteRepository.AddAsync(newCompany);
         await  _unitOfWork.SaveChangesAsync();

        return true;
    }
}
