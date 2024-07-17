using JobSearch.Application.Repositories.UserCookie;
using JobSearch.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories.UserCookie;

public class UserCookieWriteRepository : WriteRepository<Domain.Entities.UserCookies>, IUserCookieWriteRepository
{
    public UserCookieWriteRepository(AppDbContext context) : base(context)
    {
    }
}
