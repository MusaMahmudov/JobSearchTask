using JobSearch.Application.DTOs.JobTypeDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Abstractions.Services;

public interface IJobTypeService
{
    Task<bool> CreateJobTypeAsync(PostJobTypeDTO postJobTypeDTO);
}
