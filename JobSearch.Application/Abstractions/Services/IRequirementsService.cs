using JobSearch.Application.DTOs.RequirementDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Abstractions.Services;

public interface IRequirementsService
{
    Task<bool> CreateRequirementAsync(PostRequirementDTO postRequirementDTO);
}
