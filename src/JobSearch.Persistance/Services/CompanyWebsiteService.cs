using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.CompanyWebsiteDTOs;
using JobSearch.Application.Exceptions.CompanyExceptions;
using JobSearch.Applicationl;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Services;

public class CompanyWebsiteService : ICompanyWebsiteService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CompanyWebsiteService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> CreateCompanyWebsiteAsync(PostCompanyWebsiteDTO postCompanyWebsiteDTO)
    {
        var companyexists =  await _unitOfWork.CompanyReadRepository.IsExistsAsync(c=>c.Id == postCompanyWebsiteDTO.CompanyId);
        if (!companyexists)
            throw new CompanyNotFoundException("Company not found");

        var newCompanyWebsite = _mapper.Map<CompanyWebsite>(postCompanyWebsiteDTO);
        await _unitOfWork.CompanyWebsiteWriteRepository.AddAsync(newCompanyWebsite);
       await _unitOfWork.SaveChangesAsync();

        return true;

    }
}
