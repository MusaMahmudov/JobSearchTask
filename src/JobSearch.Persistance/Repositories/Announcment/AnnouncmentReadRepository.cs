using JobSearch.Application.Repositories.Announcment;
using JobSearch.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.Announcment;

public class AnnouncmentReadRepository : ReadRepository<Domain.Entities.Announcment>, IAnnouncmentReadRepository
{
    public AnnouncmentReadRepository(AppDbContext context) : base(context)
    {
    }
}
