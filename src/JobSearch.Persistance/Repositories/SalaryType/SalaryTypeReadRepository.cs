using JobSearch.Application.Repositories.SalaryType;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.SalaryType;

public class SalaryTypeReadRepository : ReadRepository<Domain.Entities.SalaryType>, ISalaryTypeReadRepository
{
    public SalaryTypeReadRepository(AppDbContext context) : base(context)
    {
    }
}
