using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.Category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.Category.Post;

public class PostCategoryCommandHandler : IRequestHandler<PostCategoryCommandRequest, PostCategoryCommandResponse>
{
    private readonly ICategoryService _categoryService;
    private readonly IMapper _mapper;
    public PostCategoryCommandHandler(ICategoryService categoryService,IMapper mapper)
    {
        _mapper = mapper;
        _categoryService = categoryService;
    }

    public async Task<PostCategoryCommandResponse> Handle(PostCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        var categoryDTO = _mapper.Map<PostCategoryDTO>(request);

       var result = await _categoryService.CreateAsync(categoryDTO);

        return new PostCategoryCommandResponse()
        {
            Message = result ? "New category created successefully" : "Something went wrong",
            StatusCode = result ? System.Net.HttpStatusCode.OK : System.Net.HttpStatusCode.BadRequest,
        };
    }
}
