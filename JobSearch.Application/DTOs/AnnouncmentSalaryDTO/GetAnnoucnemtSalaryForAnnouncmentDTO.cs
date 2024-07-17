using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.DTOs.AnnouncmentSalaryDTO;

public class GetAnnoucnemtSalaryForAnnouncmentDTO
{
    public string SalaryType { get; set; }
    public string CurrencyName { get; set; }
    public decimal MinimumSalary { get; set; }
    public decimal? MaximumSalary { get; set; }
        
}
