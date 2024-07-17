using JobSearch.Application.Repositories;
using JobSearch.Application.Repositories.Company;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.Company;

public class CompanyWriteRepository : WriteRepository<Domain.Entities.Company>, ICompanyWriteRepository
{
    public CompanyWriteRepository(AppDbContext context) : base(context)
    {
    }
}
