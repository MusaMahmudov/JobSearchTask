using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.DTOs.CompanyLocationDTOs;

public class PostCompanyLocationDTO
{
    public string Location { get; set; }
    public Guid CompanyId { get; set; }
}
