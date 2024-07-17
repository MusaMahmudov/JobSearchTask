using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.CompanyWebsiteDTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.CompanyWebsite.PostCompanyWebsite;

public class PostCompanyWebsiteCommandHandler : IRequestHandler<PostCompanyWebsiteCommandRequest, PostCompanyWebsiteCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly ICompanyWebsiteService _companyWebsiteService;
    public PostCompanyWebsiteCommandHandler(IMapper mapper,ICompanyWebsiteService companyWebsiteService)
    {
      _companyWebsiteService = companyWebsiteService;
       _mapper = mapper; 
    }

    public async Task<PostCompanyWebsiteCommandResponse> Handle(PostCompanyWebsiteCommandRequest request, CancellationToken cancellationToken)
    {
        var companyWebsiteDTO = _mapper.Map<PostCompanyWebsiteDTO>(request);

       var result = await _companyWebsiteService.CreateCompanyWebsiteAsync(companyWebsiteDTO);

        return new PostCompanyWebsiteCommandResponse()
        {
            StatusCode = result ? System.Net.HttpStatusCode.OK : System.Net.HttpStatusCode.BadRequest,
            Message = result ? "Companies' website created" : "Something get wrong"
        };
    }
}
