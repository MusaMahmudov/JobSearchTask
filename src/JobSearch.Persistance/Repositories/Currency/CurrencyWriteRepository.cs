using JobSearch.Application.Repositories.Currency;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.Currency;

public class CurrencyWriteRepository : WriteRepository<Domain.Entities.Currency>, ICurrencyWriteRepository
{
    public CurrencyWriteRepository(AppDbContext context) : base(context)
    {
    }
}
