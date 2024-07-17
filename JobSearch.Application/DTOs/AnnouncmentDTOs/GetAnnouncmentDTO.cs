using JobSearch.Application.DTOs.AnnouncmentSalaryDTO;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.DTOs.AnnouncmentDTOs;

public class GetAnnouncmentDTO
{
    public Guid Id { get; set; }
    public string CompanyName { get; set; }
    public string CategoryName { get; set; }
    public string Position { get; set; }
    public string JobTypeName { get; set; }
    public string Overview { get; set; }
    public string JobDescription { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsPremium { get; set; }
    public GetAnnoucnemtSalaryForAnnouncmentDTO? Salary { get; set; }
    public List<string>? Requirements { get; set; }

}
