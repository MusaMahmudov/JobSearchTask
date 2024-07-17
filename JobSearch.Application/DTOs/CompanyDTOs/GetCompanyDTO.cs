using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.DTOs.CompanyDTOs;

public class GetCompanyDTO
{
    public string Name { get; set; }
    public string Overview { get; set; }
    public List<string>? CompanyLocations { get; set; }
    public List<string>? CompanyWebsites { get; set; }
}
