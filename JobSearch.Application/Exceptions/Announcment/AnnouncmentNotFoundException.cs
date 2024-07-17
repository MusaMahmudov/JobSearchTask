using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.Exceptions.Announcment;

public class AnnouncmentNotFoundException : Exception, IBaseException
{
    public HttpStatusCode StatusCode => HttpStatusCode.NotFound;

    public string ErrorMessage { get; }
    public AnnouncmentNotFoundException(string message) : base(message)
    {
        ErrorMessage = message;
    }
}
