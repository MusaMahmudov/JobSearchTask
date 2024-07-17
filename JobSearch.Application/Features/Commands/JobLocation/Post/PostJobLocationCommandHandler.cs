using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.JobLocationDTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.JobLocation.Post;

public class PostJobLocationCommandHandler : IRequestHandler<PostJobLocationCommandRequest, PostJobLocationCommandResponse>
{
    private readonly IJobLocationService _jobLocationService;
    private readonly IMapper _mapper;
    public PostJobLocationCommandHandler(IMapper mapper,IJobLocationService jobLocationService)
    {
        _mapper = mapper;
        _jobLocationService = jobLocationService;
    }

    public async Task<PostJobLocationCommandResponse> Handle(PostJobLocationCommandRequest request, CancellationToken cancellationToken)
    {
        var postJobLocationDTO = _mapper.Map<PostJobLocationDTO>(request);

        var result =   await _jobLocationService.CreateAsync(postJobLocationDTO);

        return new PostJobLocationCommandResponse()
        {
            Message = result ? "New job location created successefully" : "Something went wrong",
            StatusCode = result ? System.Net.HttpStatusCode.OK : System.Net.HttpStatusCode.BadRequest,
        };
    }
}
