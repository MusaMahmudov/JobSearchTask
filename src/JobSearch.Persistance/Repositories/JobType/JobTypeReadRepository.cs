using JobSearch.Application.Repositories.JobType;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.JobType;

public class JobTypeReadRepository : ReadRepository<Domain.Entities.JobType>, IJobTypeReadRepository
{
    public JobTypeReadRepository(AppDbContext context) : base(context)
    {
    }
}
