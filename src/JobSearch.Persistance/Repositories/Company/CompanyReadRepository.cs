using JobSearch.Application.Repositories.Company;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.Company;

public class CompanyReadRepository : ReadRepository<Domain.Entities.Company>, ICompanyReadRepository
{
    public CompanyReadRepository(AppDbContext context) : base(context)
    {
    }
}
