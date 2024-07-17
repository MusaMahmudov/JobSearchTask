using AutoMapper;
using JobSearch.Application.DTOs.AnnouncmentSalaryDTO;
using JobSearch.Application.Features.Commands.Announcment.Post;
using JobSearch.Application.Features.Commands.AnnouncmentSalary.Post;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncmentSalariesController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public AnnouncmentSalariesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(PostAnnouncmentSalaryCommandRequest request)
        {
           var response = await _mediator.Send(request);

            return Ok(response);
        }
    }
}
