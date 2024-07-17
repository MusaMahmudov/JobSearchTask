using JobSearch.Application.Repositories.CompanyWebsite;
using JobSearch.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.CompanyWebsite;

public class CompanyWebsiteWriteRepository : WriteRepository<Domain.Entities.CompanyWebsite>, ICompanyWebsiteWriteRepository
{
    public CompanyWebsiteWriteRepository(AppDbContext context) : base(context)
    {
    }
}
