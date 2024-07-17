using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.UserCookie.Post;

public class PostUserCookieCommandRequest : IRequest<PostUserCookieCommandResponse>
{
    public string Address { get; set; }
}
