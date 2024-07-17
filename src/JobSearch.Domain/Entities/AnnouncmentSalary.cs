using JobSearch.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Domain.Entities;

public class AnnouncmentSalary : BaseEntity
{
    public Announcment Announcment { get; set; }
    public Guid AnnouncmentId { get; set; }
    public Guid CurrencyId { get; set; }
    public Currency Currency { get; set; }
    public SalaryType SalaryType { get; set; }
    public Guid SalaryTypeId { get; set; }
    [Range(0, double.MaxValue)]
    public decimal MinimumSalary { get; set; }
    [Range(0, double.MaxValue)]
    public decimal? MaximumSalary { get; set; }
}
