using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.JobType.Post;

public class PostJobTypeCommandRequest : IRequest<PostJobTypeCommandResponse>
{
    public string Name { get; set; }
}
