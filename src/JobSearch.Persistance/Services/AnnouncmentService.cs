using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs;
using JobSearch.Application.DTOs.AnnouncmentDTOs;
using JobSearch.Application.DTOs.AnnouncmentSalaryDTO;
using JobSearch.Application.Exceptions.AnnouncmentSalaryExceptions;
using JobSearch.Application.Exceptions.CategoryExceptions;
using JobSearch.Application.Exceptions.CompanyExceptions;
using JobSearch.Application.Exceptions.CurrencyExceptions;
using JobSearch.Application.Exceptions.JobTypeExceptions;
using JobSearch.Application.Exceptions.SalaryTypeExceptions;
using JobSearch.Applicationl;
using JobSearch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Services;

public class AnnouncmentService : IAnnouncmentService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public AnnouncmentService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    public async Task<PagedList<GetAnnouncmentDTO>> GetAllAnnouncmentsAsync(PaginationDTO paginationDTO)
    {
        var totalCount = await _unitOfWork.AnnouncmentReadRepository.GetTotalCountAsync();
        var announcments = await _unitOfWork.AnnouncmentReadRepository.GetAll(paginationDTO,false,false,"Requirements","Company","Category","JobType","Salary.Currency", "Salary.SalaryType").ToListAsync();

        var announcmentsDTO = _mapper.Map<List<GetAnnouncmentDTO>>(announcments);

        return new PagedList<GetAnnouncmentDTO>(announcmentsDTO,paginationDTO.Page,paginationDTO.Take,totalCount);


    }
    public async Task<bool> CreateAsync(PostAnnouncmentDTO postAnnouncmentDTO)
    {
        if (!await _unitOfWork.CompanyReadRepository.IsExistsAsync(c => c.Id == postAnnouncmentDTO.CompanyId))
            throw new CompanyNotFoundException("Company not found");
        if (!await _unitOfWork.JobTypeReadRepository.IsExistsAsync(jt => jt.Id == postAnnouncmentDTO.JobTypeId))
            throw new JobTypeNotFoundException("Job type not found");
        if (!await _unitOfWork.CategoryReadRepository.IsExistsAsync(c => c.Id == postAnnouncmentDTO.CategoryId))
            throw new CategoryNotFoundException("Category not found exception");

        PostAnnouncmentSalaryForAnnouncmentPostDTO? announcmentSalaryDTO = null;
        if(postAnnouncmentDTO.PostAnnouncmentSalaryForAnnouncmentPostDTO is not null)
        {
            announcmentSalaryDTO = postAnnouncmentDTO.PostAnnouncmentSalaryForAnnouncmentPostDTO;
            if (!await _unitOfWork.CurrencyReadRepository.IsExistsAsync(c => c.Id == announcmentSalaryDTO.CurrencyId))
                throw new CurrencyNotFoundException("Currency not found");
            if (!await _unitOfWork.SalaryTypeReadRepository.IsExistsAsync(st => st.Id == announcmentSalaryDTO.SalaryTypeId))
                throw new SalaryTypeNotFoundException("Salary type not found");
            if(postAnnouncmentDTO.PostAnnouncmentSalaryForAnnouncmentPostDTO.MaximumSalary is not null)
            {
                if (announcmentSalaryDTO.MaximumSalary < announcmentSalaryDTO.MinimumSalary)
                    throw new MinimumSalaryLessThanMaximumSalaryException("Minimum salary has to be less than maximum salary");
            }



        }

        try
        {
            await _unitOfWork.BeginTransactionAsync();

            var newAnnouncment = _mapper.Map<Announcment>(postAnnouncmentDTO);

            var result = await _unitOfWork.AnnouncmentWriteRepository.AddAsync(newAnnouncment);
            await _unitOfWork.SaveChangesAsync();

            if (postAnnouncmentDTO.PostAnnouncmentSalaryForAnnouncmentPostDTO != null)
            {
                
                var newAnnouncmentSalary = _mapper.Map<AnnouncmentSalary>(announcmentSalaryDTO);
                newAnnouncmentSalary.AnnouncmentId = newAnnouncment.Id;
                await _unitOfWork.AnnouncmentSalaryWriteRepository.AddAsync(newAnnouncmentSalary);
            }
            if(postAnnouncmentDTO.Requirements is not null && postAnnouncmentDTO.Requirements.Count > 0)
            {

                var newRequirements = _mapper.Map<List<Requirements>>(postAnnouncmentDTO.Requirements);
                newRequirements.ForEach(r => r.AnnouncmentId = newAnnouncment.Id);

                await _unitOfWork.RequirementsWriteRepository.AddRangeAsync(newRequirements);
                

            }


            //await _unitOfWork.SaveChangesAsync();

            await _unitOfWork.CommitAsync();
            return result;

        }
        catch (Exception ex)
        {
            await _unitOfWork.RollBackAsync();
            throw new Exception(ex.Message);
        }






    }

    public async Task<List<GetAnnouncmentDTO>> GetAnnouncmentsByCategoryIdAsync(Guid CategoryId)
    {
        if (!await _unitOfWork.CategoryReadRepository.IsExistsAsync(a => a.Id == CategoryId))
            throw new CategoryNotFoundException("Category not found");

        var announcments = _unitOfWork.AnnouncmentReadRepository.GetFiltered(a=>a.CategoryId == CategoryId,false,false,"Category");

        var announcmentsDTO = _mapper.Map<List<GetAnnouncmentDTO>>(announcments);

        return announcmentsDTO;

    }
}
