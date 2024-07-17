using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.RequirementDTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.Requirements.Post;

public class PostRequirementCommandHandler : IRequestHandler<PostRequiremtnCommandRequest, PostRequiremtnCommandResponse>
{
    private readonly IRequirementsService _requirementsService;
    private readonly IMapper _mapper;
    public PostRequirementCommandHandler(IMapper mapper,IRequirementsService requirementsService)
    {
        _mapper = mapper;
        _requirementsService = requirementsService;
    }

    public async Task<PostRequiremtnCommandResponse> Handle(PostRequiremtnCommandRequest request, CancellationToken cancellationToken)
    {
        var postRequirementDTO = _mapper.Map<PostRequirementDTO>(request);
       var result =  await _requirementsService.CreateRequirementAsync(postRequirementDTO);

        return new PostRequiremtnCommandResponse()
        {
            Message = result ? "Requirement created successefully" : "Something went wrong",
            StatusCode = result ? System.Net.HttpStatusCode.OK : System.Net.HttpStatusCode.BadRequest,
        };
    }
}
