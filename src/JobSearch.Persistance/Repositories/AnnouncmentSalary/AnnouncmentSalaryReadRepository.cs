using JobSearch.Application.Repositories.AnnouncmentSalary;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.AnnouncmentSalary;

public class AnnouncmentSalaryReadRepository : ReadRepository<Domain.Entities.AnnouncmentSalary>, IAnnouncmentSalaryReadRepository
{
    public AnnouncmentSalaryReadRepository(AppDbContext context) : base(context)
    {
    }
}
