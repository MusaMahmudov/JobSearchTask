using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.PositionGradeDTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.PositionGrade.Post;

public class PostPositionGradeCommandHandler : IRequestHandler<PostPositionGradeCommandRequest, PostPositionGradeCommandResponse>
{
    private readonly IPositionGradeService _positionGradeService;
    private readonly IMapper _mapper;
    public PostPositionGradeCommandHandler(IPositionGradeService positionGradeService, IMapper mapper)
    {
        _positionGradeService = positionGradeService;
        _mapper = mapper;
    }
    public async Task<PostPositionGradeCommandResponse> Handle(PostPositionGradeCommandRequest request, CancellationToken cancellationToken)
    {
        var postPositionGradeDTO = _mapper.Map<PostPositionGradeDTO>(request);

      var result =  await  _positionGradeService.CreatePositionGradeAsync(postPositionGradeDTO);

        return new PostPositionGradeCommandResponse()
        {
            Message = result ? "New position created successefully" : "Something get wrong",
            StatusCode = result ? System.Net.HttpStatusCode.OK : System.Net.HttpStatusCode.BadRequest,
        };
    }
}
