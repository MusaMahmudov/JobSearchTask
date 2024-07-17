using JobSearch.Application.Repositories;
using JobSearch.Application.Repositories.AnnouncmentSalary;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.AnnouncmentSalary;

public class AnnouncmentSalaryWriteRepository : WriteRepository<Domain.Entities.AnnouncmentSalary>, IAnnouncmentSalaryWriteRepository
{
    public AnnouncmentSalaryWriteRepository(AppDbContext context) : base(context)
    {
    }
}
