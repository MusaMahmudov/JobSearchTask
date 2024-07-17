using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.DTOs;

public class PaginationDTO
{
    public int Page { get; set; }
    public int Take { get; set; }
}
