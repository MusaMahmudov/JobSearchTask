﻿using JobSearch.Application.DTOs.SalaryTypeDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Abstractions.Services;

public interface ISalaryTypeService
{
    Task<bool> CreateAsync(PostSalaryTypeDTO postSalaryTypeDTO);
}
