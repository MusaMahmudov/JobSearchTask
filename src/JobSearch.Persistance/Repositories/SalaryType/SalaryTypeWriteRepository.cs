using JobSearch.Application.Repositories;
using JobSearch.Application.Repositories.SalaryType;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.SalaryType;

public class SalaryTypeWriteRepository : WriteRepository<Domain.Entities.SalaryType>, ISalaryTypeWriteRepository
{
    public SalaryTypeWriteRepository(AppDbContext context) : base(context)
    {
    }
}
