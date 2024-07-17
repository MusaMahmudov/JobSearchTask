using JobSearch.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Domain.Entities;

public class FavouriteAnnouncment : BaseEntity
{
    public Guid UserCookiesId { get; set; }
    public UserCookies UserCookies { get; set; }
    public Announcment Announcment { get; set; }
    public Guid AnnouncmentId { get; set; }
}
