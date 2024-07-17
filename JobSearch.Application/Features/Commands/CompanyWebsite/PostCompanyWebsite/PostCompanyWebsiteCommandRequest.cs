using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.CompanyWebsite.PostCompanyWebsite;

public class PostCompanyWebsiteCommandRequest : IRequest<PostCompanyWebsiteCommandResponse>
{
    public string URL { get; set; }
    public Guid CompanyId { get; set; }
}
