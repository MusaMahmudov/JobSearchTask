using JobSearch.Application.DTOs.OperatorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Abstractions.Services;

public interface IPhoneNumberOperatorService
{
    Task<bool> CreateAsync(PostPhoneNumberOperatorDTO postOperatorDTO);
}
