using JobSearch.Application.Features.Commands.Requirements.Post;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequirementsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RequirementsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(PostRequiremtnCommandRequest request)
        {
          var response = await  _mediator.Send(request);
            return Ok(response);
        }
    }
}
