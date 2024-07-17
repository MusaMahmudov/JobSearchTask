using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.SalaryTypeDTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.SalaryType.Post;

public class PostSalaryTypeCommandHandler : IRequestHandler<PostSalaryTypeCommandRequest, PostSalaryTypeCommandResponse>
{
    private readonly ISalaryTypeService _salaryTypeService;
    private readonly IMapper _mapper;
    public PostSalaryTypeCommandHandler(ISalaryTypeService salaryTypeService,IMapper mapper)
    {
        _mapper = mapper;
        _salaryTypeService = salaryTypeService;
    }

    public async Task<PostSalaryTypeCommandResponse> Handle(PostSalaryTypeCommandRequest request, CancellationToken cancellationToken)
    {
        var newSalatyTypeDTO = _mapper.Map<PostSalaryTypeDTO>(request);

      var result =  await _salaryTypeService.CreateAsync(newSalatyTypeDTO);

        return new PostSalaryTypeCommandResponse()
        {
            Message = result ? "New salary type created successefully" : "Something went wrong",
            StatusCode = result ? System.Net.HttpStatusCode.OK : System.Net.HttpStatusCode.BadRequest
        };
    }
}
