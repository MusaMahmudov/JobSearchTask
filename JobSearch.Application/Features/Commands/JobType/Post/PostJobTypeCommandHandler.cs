using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.JobTypeDTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.JobType.Post;

public class PostJobTypeCommandHandler : IRequestHandler<PostJobTypeCommandRequest, PostJobTypeCommandResponse>
{
    private readonly IJobTypeService _jobTypeService;
    private readonly IMapper _mapper;
    public PostJobTypeCommandHandler(IMapper mapper,IJobTypeService jobTypeService)
    {
        _mapper = mapper;
        _jobTypeService = jobTypeService;
    }

    public async Task<PostJobTypeCommandResponse> Handle(PostJobTypeCommandRequest request, CancellationToken cancellationToken)
    {
        var postJobTypeDTO = _mapper.Map<PostJobTypeDTO>(request);
       var result = await _jobTypeService.CreateJobTypeAsync(postJobTypeDTO);


        return new PostJobTypeCommandResponse()
        {
         Message = result ? "New job type created" : "Something went wrong",
         StatusCode = result ? System.Net.HttpStatusCode.OK : System.Net.HttpStatusCode.BadRequest,
        };
    }
}
