using JobSearch.Application.DTOs.CompanyLocationDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Abstractions.Services;

public interface ICompanyLocationService
{
    Task<bool> CreateAsync(PostCompanyLocationDTO postCompanyLocationDTO);
}
