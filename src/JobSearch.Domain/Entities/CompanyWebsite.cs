using JobSearch.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Domain.Entities;

public class CompanyWebsite : BaseEntity
{
    public string URL { get; set; }
    public Guid CompanyId { get; set; }
    public Company Company { get; set; }
}
