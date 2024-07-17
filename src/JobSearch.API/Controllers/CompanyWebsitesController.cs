using JobSearch.Application.Features.Commands.CompanyWebsite.PostCompanyWebsite;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyWebsitesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CompanyWebsitesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(PostCompanyWebsiteCommandRequest request)
        {
           var response = await _mediator.Send(request);

            return Ok(response);
        }
    }
}
