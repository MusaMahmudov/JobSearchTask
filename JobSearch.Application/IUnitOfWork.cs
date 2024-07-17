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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Applicationl;

public interface IUnitOfWork
{
    IAnnouncmentReadRepository AnnouncmentReadRepository { get; }
    IAnnouncmentWriteRepository AnnouncmentWriteRepository { get; }
    ICompanyLocationReadRepository CompanyLocationReadRepository { get; }
    ICompanyLocationWriteRepository CompanyLocationWriteRepository { get; }
    ICompanyWebsiteReadRepository CompanyWebsiteReadRepository { get; }
    ICompanyWebsiteWriteRepository CompanyWebsiteWriteRepository { get; }
    ICompanyReadRepository CompanyReadRepository { get; }
    ICompanyWriteRepository CompanyWriteRepository { get; }
    IPositionGradeReadRepository PositionGradeReadRepository { get; }
    IPositionGradeWriteRepository PositionGradeWriteRepository { get; }
    ICategoryReadRepository CategoryReadRepository { get; }
    ICategoryWriteRepository CategoryWriteRepository { get; }
    IJobTypeReadRepository JobTypeReadRepository { get; }
    IJobTypeWriteRepository JobTypeWriteRepository { get; }
    IJobLocationReadRepository JobLocationReadRepository { get; }
    IJobLocationWriteRepository JobLocationWriteRepository { get; }
    IRequirementReadRepository RequirementReadRepository { get; }
    IRequirementsWriteRepository RequirementsWriteRepository { get; }
    IPhoneNumberOperatorWriteRepository OperatorWriteRepository { get; }
    IPhoneNumberOperatorReadRepository OperatorReadRepository { get; }
    ICurrencyReadRepository CurrencyReadRepository { get; }
    ICurrencyWriteRepository CurrencyWriteRepository { get; }
    ISalaryTypeReadRepository SalaryTypeReadRepository { get; }
    ISalaryTypeWriteRepository SalaryTypeWriteRepository { get; }
    IAnnouncmentSalaryReadRepository AnnouncmentSalaryReadRepository { get; }
    IAnnouncmentSalaryWriteRepository AnnouncmentSalaryWriteRepository { get; }
    IUserCookieReadRepository UserCookieReadRepository { get; }
    IUserCookieWriteRepository UserCookieWriteRepository { get; }
    Task BeginTransactionAsync();
    Task RollBackAsync();
    Task CommitAsync();
    Task<int> SaveChangesAsync();
}
