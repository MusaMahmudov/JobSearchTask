using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Features.Commands.Company.PostCompany
{
    public class PostCompanyCommandRequest : IRequest<PostCompanyCommandResponse>
    {
        public string Name { get; set; }
        public string Overview { get; set; }
    }
}
