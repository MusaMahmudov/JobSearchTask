using JobSearch.Application.Features.Commands.PositionGrade.Post;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionGradesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PositionGradesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(PostPositionGradeCommandRequest request)
        {
           var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
