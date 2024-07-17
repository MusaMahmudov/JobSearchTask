using JobSearch.Application.DTOs.CompanyDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Abstractions.Services
{
    public interface ICompanyService
    {
        Task<bool> CreateAsync(PostCompanyDTO postCompanyDTO);

    }
}
