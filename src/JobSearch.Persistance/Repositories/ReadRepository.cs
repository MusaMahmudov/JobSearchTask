using JobSearch.Application.DTOs;
using JobSearch.Application.Repositories;
using JobSearch.Domain.Entities.Common;
using JobSearch.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _context;
    private readonly DbSet<T> Table;
    public ReadRepository(AppDbContext context)
    {
        _context = context;
        Table = _context.Set<T>();

    }

    public IQueryable<T> GetAll(PaginationDTO paginationDTO,bool ignoreFilters, bool isTracking, params string[]? includes)
    {
        var query = isTracking ? Table.AsQueryable() : Table.AsNoTracking().AsQueryable();
        query = ignoreFilters ? query.IgnoreQueryFilters() : query;
        query = query.Skip(paginationDTO.Take * (paginationDTO.Page - 1)).Take(paginationDTO.Take);

        if (includes is not null && includes.Length > 0) 
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }

        return query;
    }

    public async Task<T> GetById(Guid id, bool ignoreFilters, bool isTracking, params string[]? includes)
    {
        var query = isTracking ? Table.AsQueryable() : Table.AsNoTracking().AsQueryable();
        query = ignoreFilters ? query.IgnoreQueryFilters() : query;
        if (includes is not null && includes.Length > 0)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }

        return await query.FirstOrDefaultAsync(q=>q.Id == id);
    }

    public IQueryable<T> GetFiltered(Expression<Func<T, bool>> expression, bool ignoreFilters, bool isTracking, params string[]? includes)
    {
        var query = _context.Set<T>().AsQueryable();
         query = isTracking ? Table.AsQueryable() : Table.AsNoTracking().AsQueryable();
        query = ignoreFilters ? query.IgnoreQueryFilters() : query;
        if (includes is not null && includes.Length > 0)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }
        return query.Where(expression);

    }

    public async Task<T> GetSingle(Expression<Func<T, bool>> expression, bool ignoreFilters, bool isTracking, params string[]? includes)
    {
        var query = isTracking ? Table.AsQueryable() : Table.AsNoTracking().AsQueryable();
        query = ignoreFilters ? query.IgnoreQueryFilters() : query;
        if (includes is not null && includes.Length > 0)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }

        return await query.FirstOrDefaultAsync(expression);
    }

    public async Task<int> GetTotalCountAsync()
    {
        return await Table.CountAsync();
    }

    public async Task<bool> IsExistsAsync(Expression<Func<T, bool>> expression)
    {

        return await Table.AnyAsync(expression);
    }
}
