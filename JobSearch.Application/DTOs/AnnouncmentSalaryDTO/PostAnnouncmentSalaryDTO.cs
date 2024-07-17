using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.DTOs.AnnouncmentSalaryDTO;

public class PostAnnouncmentSalaryDTO 
{
    public Guid AnnouncmentId { get; set; }
    public Guid CurrencyId { get; set; }
    public Guid SalaryTypeId { get; set; }
    [Range(0,double.MaxValue)]
    public decimal MinimumSalary { get; set; }
    [Range(0, double.MaxValue)]
    public decimal? MaximumSalary { get; set; }
}
