using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.Currency.Post;

public class PostCurrencyCommandRequest : IRequest<PostCurrencyCommandResponse>
{
    public string Name { get; set; }
}
