using JobSearch.Application.Features.Commands.JobLocation.Post;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobLocationsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public JobLocationsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(PostJobLocationCommandRequest request)
        {
            var response = await  _mediator.Send(request);
            return Ok(response);
        }
    }
}
