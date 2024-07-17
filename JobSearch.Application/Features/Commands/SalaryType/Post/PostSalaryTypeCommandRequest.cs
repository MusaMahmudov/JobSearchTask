using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.SalaryType.Post;

public class PostSalaryTypeCommandRequest : IRequest<PostSalaryTypeCommandResponse>
{
    public string Name { get; set; }
}
