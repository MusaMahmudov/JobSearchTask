using JobSearch.Application.DTOs;
using JobSearch.Application.DTOs.AnnouncmentDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Queries.Announcment.GetAll;

public class GetAllAnnouncmentQueryResponse
{
    public PagedList<GetAnnouncmentDTO> Announcments { get; set; }
}
