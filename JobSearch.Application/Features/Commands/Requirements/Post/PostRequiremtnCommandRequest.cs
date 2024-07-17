using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.Requirements.Post;

public class PostRequiremtnCommandRequest : IRequest<PostRequiremtnCommandResponse>
{
    public string Description { get; set; }
    public Guid AnnouncmentId { get; set; }
}
