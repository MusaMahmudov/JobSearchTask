using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.Features.Commands.CompanyLocation;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyLocationsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CompanyLocationsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(PostCompanyLocationCommandRequest request)
        {
           var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
