using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.OperatorDTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.Operator.Post;

public class PostPhoneNumberOperatorCommandHandler : IRequestHandler<PostPhoneNumberOperatorCommandRequest, PostPhoneNumberOperatorCommandResponse>
{
    private readonly IPhoneNumberOperatorService _operatorService;
    private readonly IMapper _mapper;
    public PostPhoneNumberOperatorCommandHandler(IMapper mapper,IPhoneNumberOperatorService operatorService)
    {
        _mapper = mapper;
        _operatorService = operatorService; 
    }

    public async Task<PostPhoneNumberOperatorCommandResponse> Handle(PostPhoneNumberOperatorCommandRequest request, CancellationToken cancellationToken)
    {
        var postOperatorDTO = _mapper.Map<PostPhoneNumberOperatorDTO>(request);
      var result =   await _operatorService.CreateAsync(postOperatorDTO);


        return new PostPhoneNumberOperatorCommandResponse()
        {
            Message = result ? "Operator created successefully" : "Something get wrong",
            StatusCode = result ? System.Net.HttpStatusCode.OK : System.Net.HttpStatusCode.BadRequest
        };
    }
}
