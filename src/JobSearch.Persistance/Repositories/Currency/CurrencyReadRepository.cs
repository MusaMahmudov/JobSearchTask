using JobSearch.Application.Repositories;
using JobSearch.Application.Repositories.Currency;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.Currency;

public class CurrencyReadRepository : ReadRepository<Domain.Entities.Currency>, ICurrencyReadRepository
{
    public CurrencyReadRepository(AppDbContext context) : base(context)
    {
    }
}
