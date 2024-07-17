using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.AnnouncmentDTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.Announcment.Post;

public class PostAnnouncmentCommandHandler : IRequestHandler<PostAnnouncmentCommandRequest, PostAnnouncmentCommandResponse>
{
    private readonly IAnnouncmentService _announcmentService;
    private readonly IMapper _mapper;
    public PostAnnouncmentCommandHandler(IMapper mapper,IAnnouncmentService announcmentService)
    {
        _mapper = mapper;
        _announcmentService = announcmentService;
    }
    public async Task<PostAnnouncmentCommandResponse> Handle(PostAnnouncmentCommandRequest request, CancellationToken cancellationToken)
    {
        var newAnnouncmentDTO = _mapper.Map<PostAnnouncmentDTO>(request);
       var result =  await _announcmentService.CreateAsync(newAnnouncmentDTO);

        return new PostAnnouncmentCommandResponse()
        {
            StatusCode = result ? System.Net.HttpStatusCode.OK : System.Net.HttpStatusCode.BadRequest,
            Message = result ? "New announcment created" : "Something went wrong"
        };
        
    }
}
