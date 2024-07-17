using JobSearch.Application.Repositories.CompanyWebsite;
using JobSearch.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.CompanyWebsite;

public class CompanyWebsiteReadRepository : ReadRepository<Domain.Entities.CompanyWebsite>, ICompanyWebsiteReadRepository
{
    public CompanyWebsiteReadRepository(AppDbContext context) : base(context)
    {
    }
}
