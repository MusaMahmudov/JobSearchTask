using JobSearch.Application.Repositories.JobLocation;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.JobLocation
{
    public class JobLocationReadRepository : ReadRepository<Domain.Entities.JobLocation>, IJobLocationReadRepository
    {
        public JobLocationReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
