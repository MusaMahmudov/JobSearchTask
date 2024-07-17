using JobSearch.Application.DTOs.JobLocationDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Abstractions.Services;

public interface IJobLocationService 
{
    Task<bool> CreateAsync(PostJobLocationDTO postJobLocationDTO);
}
