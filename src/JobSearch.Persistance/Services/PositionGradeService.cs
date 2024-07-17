using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.PositionGradeDTOs;
using JobSearch.Applicationl;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Services;

public class PositionGradeService : IPositionGradeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public PositionGradeService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> CreatePositionGradeAsync(PostPositionGradeDTO postPositionGradeDTO)
    {
        var newPositionGrade = _mapper.Map<PositionGrade>(postPositionGradeDTO);

        await _unitOfWork.PositionGradeWriteRepository.AddAsync(newPositionGrade);
        return true;
    }
}
