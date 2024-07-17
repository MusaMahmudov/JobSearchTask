using JobSearch.Application.Repositories;
using JobSearch.Domain.Entities.Common;
using JobSearch.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _context;
    private readonly DbSet<T> Table;
    public WriteRepository(AppDbContext context)
    {
        _context = context;
        Table = _context.Set<T>();

    }

    public async Task<bool> AddAsync(T entity)
    {
        await Table.AddAsync(entity);
        return true;
    }

    public async Task<bool> AddRangeAsync(IEnumerable<T> entities)
    {
       await Table.AddRangeAsync(entities);
        return true;
    }

    public bool Delete(T entity)
    {
        Table.Remove(entity);
        return true;
    }

    public bool Update(T entity)
    {
        Table.Update(entity);
        return true;
    }
}
