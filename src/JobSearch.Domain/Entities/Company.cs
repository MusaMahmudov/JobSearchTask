using JobSearch.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Domain.Entities;

public class Company : BaseEntity
{
    
    public string Name { get; set; }
    public string Overview { get; set; }
    public ICollection<CompanyLocation>? CompanyLocations { get; set; }
    public ICollection<CompanyWebsite>? CompanyWebsites { get; set; }
}
