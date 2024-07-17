using JobSearch.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Domain.Entities;

public class Requirements : BaseEntity
{
    public string Description { get; set; }
    public Guid AnnouncmentId { get; set; }
    public Announcment Announcment { get; set; }
}
