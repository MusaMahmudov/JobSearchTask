using JobSearch.Application.DTOs.AnnouncmentSalaryDTO;
using JobSearch.Application.DTOs.RequirementDTOs;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.DTOs.AnnouncmentDTOs;

public class PostAnnouncmentDTO
{
    public Guid CompanyId { get; set; }
    public Guid CategoryId { get; set; }
    public string Position { get; set; }
    public Guid JobTypeId { get; set; }
    public string Overview { get; set; }
    public string JobDescription { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsPremium { get; set; }
    public PostAnnouncmentSalaryForAnnouncmentPostDTO? PostAnnouncmentSalaryForAnnouncmentPostDTO { get; set; }
    public List<PostRequirementForAnnouncmentDTO>? Requirements { get; set; }
}
