using JobSearch.Application.Repositories.CompanyLocation;
using JobSearch.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.CompanyLocation;

public class CompanyLocationReadRepository : ReadRepository<Domain.Entities.CompanyLocation>, ICompanyLocationReadRepository
{
    public CompanyLocationReadRepository(AppDbContext context) : base(context)
    {
    }
}
