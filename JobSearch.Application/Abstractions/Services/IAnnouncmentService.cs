using JobSearch.Application.DTOs;
using JobSearch.Application.DTOs.AnnouncmentDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Abstractions.Services;

public interface IAnnouncmentService
{
    Task<PagedList<GetAnnouncmentDTO>> GetAllAnnouncmentsAsync(PaginationDTO paginationDTO);
    Task<bool> CreateAsync(PostAnnouncmentDTO postAnnouncmentDTO);
    Task<List<GetAnnouncmentDTO>> GetAnnouncmentsByCategoryIdAsync(Guid CategoryId);
    
}
