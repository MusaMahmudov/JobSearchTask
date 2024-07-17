using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.CookieDTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.UserCookie.Post;

public class PostUserCookieCommandHandler : IRequestHandler<PostUserCookieCommandRequest, PostUserCookieCommandResponse>
{
    private readonly IUserCookieService _cookieUserService;
    private readonly IMapper _mapper;
    public PostUserCookieCommandHandler(IMapper mapper, IUserCookieService cookieUserService)
    {
        _mapper = mapper;
        _cookieUserService = cookieUserService;
    }

    public async Task<PostUserCookieCommandResponse> Handle(PostUserCookieCommandRequest request, CancellationToken cancellationToken)
    {
        var postUserCookieDTO = _mapper.Map<PostUserCookieDTO>(request);

         var result = await _cookieUserService.CreateAsync(postUserCookieDTO);

        return new PostUserCookieCommandResponse()
        {
            Message = result ? "User's cookie created successefully" : "Something went wrong",
            StatusCode = result ? System.Net.HttpStatusCode.OK : System.Net.HttpStatusCode.BadRequest
        };
    }
}
