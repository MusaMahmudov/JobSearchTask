using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.AnnouncmentSalaryDTO;
using JobSearch.Application.Exceptions.Announcment;
using JobSearch.Application.Exceptions.AnnouncmentSalaryExceptions;
using JobSearch.Application.Exceptions.CurrencyExceptions;
using JobSearch.Application.Exceptions.SalaryTypeExceptions;
using JobSearch.Applicationl;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Services;

public class AnnouncmentSalaryService : IAnnouncmentSalaryService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    public AnnouncmentSalaryService(IMapper mapper,IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<bool> CreateAsync(PostAnnouncmentSalaryDTO postAnnouncmentSalaryDTO)
    {
        if (!await _unitOfWork.AnnouncmentReadRepository.IsExistsAsync(a => a.Id == postAnnouncmentSalaryDTO.AnnouncmentId))
            throw new AnnouncmentNotFoundException("Announcment not found");

        if (!await _unitOfWork.CurrencyReadRepository.IsExistsAsync(c => c.Id == postAnnouncmentSalaryDTO.CurrencyId))
            throw new CurrencyNotFoundException("Currecy not found");
        if (!await _unitOfWork.SalaryTypeReadRepository.IsExistsAsync(jt => jt.Id == postAnnouncmentSalaryDTO.SalaryTypeId))
            throw new SalaryTypeNotFoundException("Salary type not found");
        if(postAnnouncmentSalaryDTO.MaximumSalary is not null)
        {
            if (postAnnouncmentSalaryDTO.MinimumSalary >= postAnnouncmentSalaryDTO.MaximumSalary)
                throw new MinimumSalaryLessThanMaximumSalaryException("Minimum salaryhas to be less than maximum salary");

        }


        var newAnnouncmentSalary = _mapper.Map<AnnouncmentSalary>(postAnnouncmentSalaryDTO);

        var result = await _unitOfWork.AnnouncmentSalaryWriteRepository.AddAsync(newAnnouncmentSalary);
        await _unitOfWork.SaveChangesAsync();

        return result;
        


    }
}
