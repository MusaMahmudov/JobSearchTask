using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.Category;
using JobSearch.Applicationl;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Services;

public class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CategoryService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> CreateAsync(PostCategoryDTO postCategoryDTO)
    {
        var newCategory = _mapper.Map<Category>(postCategoryDTO);

      var result = await _unitOfWork.CategoryWriteRepository.AddAsync(newCategory);
       await _unitOfWork.SaveChangesAsync();
        
        return result;
    }
}
