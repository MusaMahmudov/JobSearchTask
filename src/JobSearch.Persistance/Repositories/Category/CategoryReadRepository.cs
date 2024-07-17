using JobSearch.Application.Repositories.Category;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.Category;

public class CategoryReadRepository : ReadRepository<Domain.Entities.Category>, ICategoryReadRepository
{
    public CategoryReadRepository(AppDbContext context) : base(context)
    {
    }
}
