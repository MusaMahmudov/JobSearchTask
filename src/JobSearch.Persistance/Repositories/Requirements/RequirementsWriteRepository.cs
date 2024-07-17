using JobSearch.Application.Repositories.Requirement;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.Requirements;

public class RequirementsWriteRepository : WriteRepository<Domain.Entities.Requirements>, IRequirementsWriteRepository
{
    public RequirementsWriteRepository(AppDbContext context) : base(context)
    {
    }
}
