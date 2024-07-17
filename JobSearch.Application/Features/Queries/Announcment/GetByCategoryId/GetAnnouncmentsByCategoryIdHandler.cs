using JobSearch.Application.Abstractions.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Queries.Announcment.GetByCategoryId;

public class GetAnnouncmentsByCategoryIdHandler : IRequestHandler<GetAnnouncmentsByCategoryIdRequest, GetAnnouncmentsByCategoryIdResponse>
{
    private readonly IAnnouncmentService _announcmentService;
    
    public GetAnnouncmentsByCategoryIdHandler(IAnnouncmentService announcmentService)
    {
        _announcmentService = announcmentService;
    }
    public async Task<GetAnnouncmentsByCategoryIdResponse> Handle(GetAnnouncmentsByCategoryIdRequest request, CancellationToken cancellationToken)
    {
        var announcments = await _announcmentService.GetAnnouncmentsByCategoryIdAsync(request.CategoryId);

        return new GetAnnouncmentsByCategoryIdResponse
        {
            Announcments = announcments
        };
    }
}
