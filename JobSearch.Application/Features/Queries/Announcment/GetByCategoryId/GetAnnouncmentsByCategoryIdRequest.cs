using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Queries.Announcment.GetByCategoryId;

public class GetAnnouncmentsByCategoryIdRequest : IRequest<GetAnnouncmentsByCategoryIdResponse>
{
    public Guid CategoryId { get; set; }
}
