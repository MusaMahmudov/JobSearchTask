using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs;
using JobSearch.Application.DTOs.AnnouncmentDTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Queries.Announcment.GetAll;

public class GetAllAnnouncmentQueryHandler : IRequestHandler<GetAllAnnouncmentQueryRequest, GetAllAnnouncmentQueryResponse>
{
    private readonly IAnnouncmentService _announcmentService;
    private readonly IMapper _mapper;
    public GetAllAnnouncmentQueryHandler(IAnnouncmentService announcmentService,IMapper mapper)
    {
        _mapper = mapper;
        _announcmentService = announcmentService;
    }

    public async Task<GetAllAnnouncmentQueryResponse> Handle(GetAllAnnouncmentQueryRequest request, CancellationToken cancellationToken)
    {
        var announcmentsDTO = await _announcmentService.GetAllAnnouncmentsAsync(new PaginationDTO() { Page = request.Page,Take = request.Take});

        return new GetAllAnnouncmentQueryResponse() { Announcments = announcmentsDTO };
    }
}
