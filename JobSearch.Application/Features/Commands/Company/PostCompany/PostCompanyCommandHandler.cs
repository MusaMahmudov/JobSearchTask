using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.CompanyDTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.Company.PostCompany;

public class PostCompanyCommandHandler : IRequestHandler<PostCompanyCommandRequest, PostCompanyCommandResponse>
{
    private readonly ICompanyService _companyService;
    private readonly IMapper _mapper;
    public PostCompanyCommandHandler(IMapper mapper,ICompanyService companyService)
    {
        _mapper = mapper;
        _companyService = companyService;
    }

    public async Task<PostCompanyCommandResponse> Handle(PostCompanyCommandRequest request, CancellationToken cancellationToken)
    {
        var newCompanyDTO = _mapper.Map<PostCompanyDTO>(request);

       var result = await  _companyService.CreateAsync(newCompanyDTO);

        return new PostCompanyCommandResponse()
        {
            StatusCode = result ? HttpStatusCode.OK : HttpStatusCode.BadRequest,
            Message = result ? "New Company added successefully" : "Something went wrong"
        };

    }
}
