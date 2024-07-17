using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.Operator.Post;

public class PostPhoneNumberOperatorCommandRequest : IRequest<PostPhoneNumberOperatorCommandResponse>
{
    public string Operator { get; set; }
    public string Root { get; set; }
}
