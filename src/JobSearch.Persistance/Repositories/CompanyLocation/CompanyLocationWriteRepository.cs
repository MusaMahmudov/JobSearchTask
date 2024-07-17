using JobSearch.Application.Repositories.CompanyLocation;
using JobSearch.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.CompanyLocation;

public class CompanyLocationWriteRepository : WriteRepository<Domain.Entities.CompanyLocation>, ICompanyLocationWriteRepository
{
    public CompanyLocationWriteRepository(AppDbContext context) : base(context)
    {
    }
}
