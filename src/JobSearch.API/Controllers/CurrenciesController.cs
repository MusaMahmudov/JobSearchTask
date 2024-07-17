using JobSearch.Application.DTOs.CurrencyDTO;
using JobSearch.Application.Features.Commands.Category.Post;
using JobSearch.Application.Features.Commands.Currency.Post;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CurrenciesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(PostCurrencyCommandRequest request)
        {
         var response = await   _mediator.Send(request);
            return Ok(response);
        }
    }
}
