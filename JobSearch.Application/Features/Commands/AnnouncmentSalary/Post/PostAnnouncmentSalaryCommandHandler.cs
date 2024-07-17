using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.AnnouncmentSalaryDTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.AnnouncmentSalary.Post;

public class PostAnnouncmentSalaryCommandHandler : IRequestHandler<PostAnnouncmentSalaryCommandRequest, PostAnnouncmentSalaryCommandResponse>
{
    private readonly IAnnouncmentSalaryService _announcmentSalaryService;
    private readonly IMapper _mapper;
    public PostAnnouncmentSalaryCommandHandler(IAnnouncmentSalaryService announcmentSalaryService,IMapper mapper)
    {
        _mapper = mapper;
        _announcmentSalaryService = announcmentSalaryService;
    }

    public async Task<PostAnnouncmentSalaryCommandResponse> Handle(PostAnnouncmentSalaryCommandRequest request, CancellationToken cancellationToken)
    {
        var announcmentSalaryDTO = _mapper.Map<PostAnnouncmentSalaryDTO>(request);

        var result =  await _announcmentSalaryService.CreateAsync(announcmentSalaryDTO);

        return new PostAnnouncmentSalaryCommandResponse()
        {
            Message = result ? "Announcment's salary created successefully" : "Something get wrong",
            StatusCode = result ? System.Net.HttpStatusCode.OK : System.Net.HttpStatusCode.BadRequest,
        };
    }
}
