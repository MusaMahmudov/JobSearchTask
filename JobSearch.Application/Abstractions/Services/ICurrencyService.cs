using JobSearch.Application.DTOs.CurrencyDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Abstractions.Services;

public interface ICurrencyService
{
    Task<bool> CreateAsync(PostCurrencyDTO postCurrencyDTO);
}
