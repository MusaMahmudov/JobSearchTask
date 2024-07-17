using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.DTOs.RequirementDTOs;

public class PostRequirementDTO
{
    public string Description { get; set; }
    public Guid AnnouncmentId { get; set; }
}
