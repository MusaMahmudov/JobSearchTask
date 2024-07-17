using JobSearch.Application.Repositories;
using JobSearch.Application.Repositories.Requirement;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.Requirements;

public class RequirementsReadRepository : ReadRepository<Domain.Entities.Requirements>, IRequirementReadRepository
{
    public RequirementsReadRepository(AppDbContext context) : base(context)
    {
    }
}
