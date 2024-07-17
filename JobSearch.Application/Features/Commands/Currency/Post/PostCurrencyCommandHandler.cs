using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.CurrencyDTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.Currency.Post;

public class PostCurrencyCommandHandler : IRequestHandler<PostCurrencyCommandRequest, PostCurrencyCommandResponse>
{
    private readonly ICurrencyService _currencyService;
    private readonly IMapper _mapper;
    public PostCurrencyCommandHandler(IMapper mapper,ICurrencyService currencyService)
    {
        _mapper = mapper;
        _currencyService = currencyService;
    }

    public async Task<PostCurrencyCommandResponse> Handle(PostCurrencyCommandRequest request, CancellationToken cancellationToken)
    {
        var newCurrencyDTO = _mapper.Map<PostCurrencyDTO>(request);

        var result = await _currencyService.CreateAsync(newCurrencyDTO);

        return new PostCurrencyCommandResponse()
        {
            StatusCode = result ? System.Net.HttpStatusCode.OK : System.Net.HttpStatusCode.BadRequest,
            Message = result ? "New currency created successefully" : "Something get wrong"
        };
    }
}
