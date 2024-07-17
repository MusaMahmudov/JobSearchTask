﻿using JobSearch.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Domain.Entities;

public class UserCookies : BaseEntity
{
    public string Address   { get; set; }
    public ICollection<FavouriteAnnouncment>? FavouriteAnnouncments { get; set; }

}
