using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Queries.Announcment.GetAll;

public class GetAllAnnouncmentQueryRequest : IRequest<GetAllAnnouncmentQueryResponse>
{
    public int Page { get; set; }
    public int Take { get; set; }
}
