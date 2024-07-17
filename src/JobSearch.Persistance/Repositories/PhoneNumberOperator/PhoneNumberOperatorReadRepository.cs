using JobSearch.Application.Repositories.Operator;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.Operator;

public class PhoneNumberOperatorReadRepository : ReadRepository<Domain.Entities.PhoneNumberOperator>, IPhoneNumberOperatorReadRepository
{
    public PhoneNumberOperatorReadRepository(AppDbContext context) : base(context)
    {
    }
}
