using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Exceptions.AnnouncmentSalaryExceptions;

public class MinimumSalaryLessThanMaximumSalaryException : Exception, IBaseException
{
    public HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

    public string ErrorMessage { get; }
    public MinimumSalaryLessThanMaximumSalaryException(string message) : base(message)
    {
        ErrorMessage = message;
    }
}
