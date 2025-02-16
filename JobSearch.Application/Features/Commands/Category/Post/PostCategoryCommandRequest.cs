﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.Category.Post;

public class PostCategoryCommandRequest : IRequest<PostCategoryCommandResponse>
{
    public string Name { get; set; }
}
