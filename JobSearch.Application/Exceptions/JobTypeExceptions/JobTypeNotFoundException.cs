using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Exceptions.JobTypeExceptions;

public class JobTypeNotFoundException : Exception, IBaseException
{
    public HttpStatusCode StatusCode => HttpStatusCode.NotFound;

    public string ErrorMessage { get; }
    public JobTypeNotFoundException(string message) : base(message)
    {
        ErrorMessage = message;
    }
}
