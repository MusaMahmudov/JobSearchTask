using JobSearch.Application.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Abstractions.Services
{
    public interface ICategoryService
    {
        Task<bool> CreateAsync(PostCategoryDTO postCategoryDTO);
    }
}
