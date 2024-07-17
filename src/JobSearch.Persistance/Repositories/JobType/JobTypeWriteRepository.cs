using JobSearch.Application.Repositories.JobType;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.JobType;

public class JobTypeWriteRepository : WriteRepository<Domain.Entities.JobType>, IJobTypeWriteRepository
{
    public JobTypeWriteRepository(AppDbContext context) : base(context)
    {
    }
}
