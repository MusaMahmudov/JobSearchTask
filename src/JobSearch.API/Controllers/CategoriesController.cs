using JobSearch.Application.Features.Commands.Category.Post;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CategoriesController(IMediator mediator) 
        {
         _mediator = mediator;
        }
        [HttpPost]  
        public async Task<IActionResult> Create(PostCategoryCommandRequest request)
        {
           var response = await _mediator.Send(request);

            return Ok(response);
        }
    }
}
