using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.CompanyLocationDTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.CompanyLocation;

public class PostCompanyLocationCommandHandler : IRequestHandler<PostCompanyLocationCommandRequest, PostCompanyLocationCommandResponse>
{
    private readonly ICompanyLocationService _companyLocationService;
    private readonly IMapper _mapper;
    public PostCompanyLocationCommandHandler(IMapper mapper,ICompanyLocationService companyLocationService)
    {
        _mapper = mapper;
        _companyLocationService = companyLocationService;
    }

    public async Task<PostCompanyLocationCommandResponse> Handle(PostCompanyLocationCommandRequest request, CancellationToken cancellationToken)
    {
        var newCompanyLocationDTO = _mapper.Map<PostCompanyLocationDTO>(request);

       var result = await _companyLocationService.CreateAsync(newCompanyLocationDTO);

        return new PostCompanyLocationCommandResponse()
        {
            StatusCode = result ? System.Net.HttpStatusCode.OK : System.Net.HttpStatusCode.BadRequest,
            Message = result ? "Company location created successsefully" : "Something get wrong" 
        };
    }
}
