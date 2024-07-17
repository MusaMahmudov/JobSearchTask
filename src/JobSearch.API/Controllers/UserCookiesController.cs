using JobSearch.Application.Features.Commands.UserCookie.Post;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCookiesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserCookiesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(PostUserCookieCommandRequest request)
        {
          var response = await  _mediator.Send(request);
            return Ok(response);
        }
    }
}
