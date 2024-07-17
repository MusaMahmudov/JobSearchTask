using JobSearch.Application.Features.Commands.Operator.Post;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneNumberOperatorsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PhoneNumberOperatorsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(PostPhoneNumberOperatorCommandRequest request)
        {
           var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
