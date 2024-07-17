using JobSearch.Application.Features.Commands.SalaryType.Post;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryTypesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SalaryTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(PostSalaryTypeCommandRequest request)
        {
           var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
