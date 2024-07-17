using JobSearch.Application.DTOs.AnnouncmentDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Queries.Announcment.GetByCategoryId;

public class GetAnnouncmentsByCategoryIdResponse 
{
    public List<GetAnnouncmentDTO> Announcments { get; set; }
}
