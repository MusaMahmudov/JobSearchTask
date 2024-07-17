using JobSearch.Application.Features.Commands.Company.PostCompany;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application;

public static class ServiceRegistration
{
    public static IServiceCollection UseApplicationServices(this IServiceCollection collection)
    {
        collection.AddMediatR(crg=>crg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return collection;  
    }
}
