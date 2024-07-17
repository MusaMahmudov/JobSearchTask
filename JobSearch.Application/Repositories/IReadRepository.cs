using JobSearch.Application.DTOs;
using JobSearch.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Repositories;

public interface IReadRepository<T> where T : BaseEntity
{
    IQueryable<T> GetAll(PaginationDTO paginationDTO, bool ignoreFilters = false, bool isTracking = false, params string[]? includes);
    IQueryable<T> GetFiltered(Expression<Func<T,bool>> expression, bool ignoreFilters = false, bool isTracking  = false, params string[]? includes);
    Task<T> GetById(Guid id, bool ignoreFilters = false, bool isTracking = false,params string[]? includes);
    Task<T> GetSingle(Expression<Func<T, bool>> expression, bool ignoreFilters = false, bool isTracking = false, params string[]? includes);
    Task<bool> IsExistsAsync(Expression<Func<T,bool>> expression);
    Task<int> GetTotalCountAsync();

}
