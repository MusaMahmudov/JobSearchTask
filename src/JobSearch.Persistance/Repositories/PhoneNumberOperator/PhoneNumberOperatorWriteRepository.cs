using JobSearch.Application.Repositories.Operator;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.Operator;

public class PhoneNumberOperatorWriteRepository : WriteRepository<Domain.Entities.PhoneNumberOperator>, IPhoneNumberOperatorWriteRepository
{
    public PhoneNumberOperatorWriteRepository(AppDbContext context) : base(context)
    {
    }
}
