using AutoMapper;
using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.DTOs.CookieDTOs;
using JobSearch.Applicationl;
using JobSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Services;

public class UserCookieService : IUserCookieService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public UserCookieService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> CreateAsync(PostUserCookieDTO postUserCookieDTO)
    {
        var newUserCookie = _mapper.Map<UserCookies>(postUserCookieDTO);
       var result = await _unitOfWork.UserCookieWriteRepository.AddAsync(newUserCookie);
        await _unitOfWork.SaveChangesAsync();

        return result;
    }
}
