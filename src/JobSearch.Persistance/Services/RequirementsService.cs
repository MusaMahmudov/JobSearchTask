using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.RequirementDTOs;
using JobSearch.Application.Exceptions.Announcment;
using JobSearch.Applicationl;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Services;

public class RequirementsService : IRequirementsService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public RequirementsService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> CreateRequirementAsync(PostRequirementDTO postRequirementDTO)
    {
        if (await _unitOfWork.AnnouncmentReadRepository.IsExistsAsync(c => c.Id == postRequirementDTO.AnnouncmentId))
            throw new AnnouncmentNotFoundException("Announcment not found");

        var newRequirement = _mapper.Map<Requirements>(postRequirementDTO);
        await  _unitOfWork.RequirementsWriteRepository.AddAsync(newRequirement);

        return true;
    }
}
