using JobSearch.Application.Repositories.PositionGrade;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.PositionGrade;

public class PositionGradeReadRepository : ReadRepository<Domain.Entities.PositionGrade>, IPositionGradeReadRepository
{
    public PositionGradeReadRepository(AppDbContext context) : base(context)
    {
    }
}
