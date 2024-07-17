using JobSearch.Application.Repositories.Announcment;
using JobSearch.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.Announcment;

public class AnnouncmentWriteRepository : WriteRepository<Domain.Entities.Announcment>, IAnnouncmentWriteRepository
{
    public AnnouncmentWriteRepository(AppDbContext context) : base(context)
    {
    }
}
