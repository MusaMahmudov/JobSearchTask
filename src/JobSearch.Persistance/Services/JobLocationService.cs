using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.JobLocationDTO;
using JobSearch.Applicationl;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Services;

public class JobLocationService : IJobLocationService
{
    private readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public JobLocationService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<bool> CreateAsync(PostJobLocationDTO postJobLocationDTO)
    {
        var newJobLocation = _mapper.Map<JobLocation>(postJobLocationDTO);

        var result =  await _unitOfWork.JobLocationWriteRepository.AddAsync(newJobLocation);
        await _unitOfWork.SaveChangesAsync();

        return result;
    }
}
