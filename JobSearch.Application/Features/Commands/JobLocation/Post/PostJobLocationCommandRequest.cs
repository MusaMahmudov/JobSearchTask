using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.JobLocation.Post
{
    public class PostJobLocationCommandRequest : IRequest<PostJobLocationCommandResponse>
    {
        public string Name { get; set; }
    }
}
