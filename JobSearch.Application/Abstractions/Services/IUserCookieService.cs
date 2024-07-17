using JobSearch.Application.DTOs.CookieDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Abstractions.Services;

public interface IUserCookieService
{
    Task<bool> CreateAsync(PostUserCookieDTO postUserCookieDTO);
}
