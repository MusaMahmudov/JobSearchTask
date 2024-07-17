using JobSearch.Application.DTOs.PositionGradeDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Abstractions.Services;

public interface IPositionGradeService
{
    Task<bool> CreatePositionGradeAsync(PostPositionGradeDTO postPositionGradeDTO);
}
