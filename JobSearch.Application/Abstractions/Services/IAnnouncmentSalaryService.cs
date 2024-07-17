using JobSearch.Application.DTOs.AnnouncmentSalaryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Abstractions.Services;

public interface IAnnouncmentSalaryService
{
    Task<bool> CreateAsync(PostAnnouncmentSalaryDTO postAnnouncmentSalaryDTO);
}
