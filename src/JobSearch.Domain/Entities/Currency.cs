using JobSearch.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Domain.Entities;

public class Currency : BaseEntity
{
    public string Name { get; set; }
    public ICollection<AnnouncmentSalary>? announcmentSalaries { get; set; }
}
