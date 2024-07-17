using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.JobTypeDTOs;
using JobSearch.Applicationl;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Services;

public class JobTypeService : IJobTypeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public JobTypeService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> CreateJobTypeAsync(PostJobTypeDTO postJobTypeDTO)
    {
        var newJobType = _mapper.Map<JobType>(postJobTypeDTO);

        var result = await _unitOfWork.JobTypeWriteRepository.AddAsync(newJobType);
      await  _unitOfWork.SaveChangesAsync();

        return result;
    }
}
