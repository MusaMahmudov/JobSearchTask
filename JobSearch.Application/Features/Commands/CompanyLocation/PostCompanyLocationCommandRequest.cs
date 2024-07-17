using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.CompanyLocation;

public class PostCompanyLocationCommandRequest : IRequest<PostCompanyLocationCommandResponse>
{
    public string Location { get; set; }
    public Guid CompanyId { get; set; }

}
