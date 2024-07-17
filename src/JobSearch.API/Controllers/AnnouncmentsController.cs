using JobSearch.Application.Features.Commands.Announcment.Post;
using JobSearch.Application.Features.Queries.Announcment.GetAll;
using JobSearch.Application.Features.Queries.Announcment.GetByCategoryId;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncmentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<AnnouncmentsController> _logger;
        public AnnouncmentsController(IMediator mediator, ILogger<AnnouncmentsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] int Page, int Take)
        {
            var announcments = await _mediator.Send(new GetAllAnnouncmentQueryRequest() { Page = Page, Take = Take });
            _logger.LogInformation($"Get all menthod started in Announcment's controller. Page:{Page} - Take:{Take}");
            return Ok(announcments);
        }
        [HttpGet("{CategoryId}")]
        public async Task<IActionResult> GetByCategoryId(Guid CategoryId)
        {
            var announcments = await _mediator.Send(new GetAnnouncmentsByCategoryIdRequest() { CategoryId = CategoryId});

            return Ok(announcments);
        }
        [HttpPost]
        public async Task<IActionResult> Create(PostAnnouncmentCommandRequest request)
        {
           var response = await _mediator.Send(request); 
            return Ok(response);
        }
        
    }
}
