﻿using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.DTOs.CompanyWebsiteDTOs;

public class PostCompanyWebsiteDTO
{
    public string URL { get; set; }
    public Guid CompanyId { get; set; }
}
