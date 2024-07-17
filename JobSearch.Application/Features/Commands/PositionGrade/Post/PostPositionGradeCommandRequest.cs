using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.PositionGrade.Post;

public class PostPositionGradeCommandRequest : IRequest<PostPositionGradeCommandResponse>
{
    public string Name { get; set; }
}
