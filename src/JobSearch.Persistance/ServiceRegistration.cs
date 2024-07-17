using JobSearch.Application.Abstractions.Services;
using JobSearch.Application.Repositories.Announcment;
using JobSearch.Application.Repositories.AnnouncmentSalary;
using JobSearch.Application.Repositories.Category;
using JobSearch.Application.Repositories.Company;
using JobSearch.Application.Repositories.CompanyLocation;
using JobSearch.Application.Repositories.CompanyWebsite;
using JobSearch.Application.Repositories.Currency;
using JobSearch.Application.Repositories.JobLocation;
using JobSearch.Application.Repositories.JobType;
using JobSearch.Application.Repositories.Operator;
using JobSearch.Application.Repositories.PositionGrade;
using JobSearch.Application.Repositories.Requirement;
using JobSearch.Application.Repositories.SalaryType;
using JobSearch.Application.Repositories.UserCookie;
using JobSearch.Applicationl;
using JobSearch.Persistance.Contexts;
using JobSearch.Persistance.Mappers;
using JobSearch.Persistance.Repositories;
using JobSearch.Persistance.Repositories.Announcment;
using JobSearch.Persistance.Repositories.AnnouncmentSalary;
using JobSearch.Persistance.Repositories.Category;
using JobSearch.Persistance.Repositories.Company;
using JobSearch.Persistance.Repositories.CompanyLocation;
using JobSearch.Persistance.Repositories.CompanyWebsite;
using JobSearch.Persistance.Repositories.Currency;
using JobSearch.Persistance.Repositories.JobLocation;
using JobSearch.Persistance.Repositories.JobType;
using JobSearch.Persistance.Repositories.Operator;
using JobSearch.Persistance.Repositories.PositionGrade;
using JobSearch.Persistance.Repositories.Requirements;
using JobSearch.Persistance.Repositories.SalaryType;
using JobSearch.Persistance.Repositories.UserCookie;
using JobSearch.Persistance.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance;

public static class ServiceRegistration
{
    public static IServiceCollection UsePersistanceServices(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddAutoMapper(typeof(CompanyMapper).Assembly);
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ICompanyService,CompanyService>();
        //services.AddScoped<ICompanyReadRepository,CompanyReadRepository>();
        //services.AddScoped<ICompanyWriteRepository,CompanyWriteRepository>();
        services.AddScoped<ICompanyWebsiteService,CompanyWebsiteService>();
        //services.AddScoped<ICompanyWebsiteReadRepository, CompanyWebsiteReadRepository>();
        //services.AddScoped<ICompanyWebsiteWriteRepository,CompanyWebsiteWriteRepository>();
        services.AddScoped<ICompanyLocationService,CompanyLocationService>();
        //services.AddScoped<ICompanyLocationReadRepository,CompanyLocationReadRepository>();
        //services.AddScoped<ICompanyLocationWriteRepository,CompanyLocationWriteRepository>();
        services.AddScoped<IPositionGradeService, PositionGradeService>();
        //services.AddScoped<IPositionGradeReadRepository,PositionGradeReadRepository>();
        //services.AddScoped<IPositionGradeWriteRepository, PositionGradeWriteRepository>();
        services.AddScoped<ICategoryService,CategoryService>();

        //services.AddScoped<ICategoryReadRepository,CategoryReadRepository>();
        //services.AddScoped<ICategoryWriteRepository,CategoryWriteRepository>();

        services.AddScoped<IJobTypeService,JobTypeService>();
        //services.AddScoped<IJobTypeReadRepository,JobTypeReadRepository>();
        //services.AddScoped<IJobTypeWriteRepository,JobTypeWriteRepository>();

        //services.AddScoped<IJobLocationReadRepository,JobLocationReadRepository>();
        //services.AddScoped<IJobLocationWriteRepository,JobLocationWriteRepository>();
        services.AddScoped<IJobLocationService,JobLocationService>();

        services.AddScoped<IRequirementsService,RequirementsService>();
        //services.AddScoped<IRequirementReadRepository,RequirementsReadRepository>();
        //services.AddScoped<IRequirementsWriteRepository, RequirementsWriteRepository>();
        services.AddScoped<IPhoneNumberOperatorService,PhoneNumberOperatorService>();
        //services.AddScoped<IPhoneNumberOperatorReadRepository,PhoneNumberOperatorReadRepository>();
        //services.AddScoped<IPhoneNumberOperatorWriteRepository,PhoneNumberOperatorWriteRepository>();

        services.AddScoped<IAnnouncmentService, AnnouncmentService>();
        //services.AddScoped<IAnnouncmentReadRepository,AnnouncmentReadRepository>();
        //services.AddScoped<IAnnouncmentWriteRepository,AnnouncmentWriteRepository>();

        //services.AddScoped<ICurrencyReadRepository, CurrencyReadRepository>();
        //services.AddScoped<ICurrencyWriteRepository, CurrencyWriteRepository>();
        services.AddScoped<ICurrencyService, CurrencyService>();

        services.AddScoped<ISalaryTypeService,SalaryTypeService>();
        //services.AddScoped<ISalaryTypeReadRepository,SalaryTypeReadRepository>();
        //services.AddScoped<ISalaryTypeWriteRepository, SalaryTypeWriteRepository>();

        services.AddScoped<IAnnouncmentSalaryService, AnnouncmentSalaryService>();
        //services.AddScoped<IAnnouncmentSalaryReadRepository, AnnouncmentSalaryReadRepository>();
        //services.AddScoped<IAnnouncmentSalaryWriteRepository,AnnouncmentSalaryWriteRepository>();

        //services.AddScoped<IUserCookieWriteRepository,UserCookieWriteRepository>();
        //services.AddScoped<IUserCookieReadRepository, UserCookieReadRepository>();
        services.AddScoped<IUserCookieService, UserCookieService>();
        services.AddDbContext<AppDbContext>(context =>
        {
            context.UseSqlServer(configuration.GetConnectionString("Default"));
        });




        return services;
    }
}
