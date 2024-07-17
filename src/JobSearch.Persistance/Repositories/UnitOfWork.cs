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
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Persistance.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    IAnnouncmentReadRepository _announcmentReadRepository;
    IAnnouncmentWriteRepository _announcmentWriteRepository;
    ICompanyLocationWriteRepository _companyLocationWriteRepository;
    ICompanyLocationReadRepository _companyLocationReadRepository;
    ICompanyWebsiteReadRepository _companyWebsiteReadRepository;
    ICompanyWebsiteWriteRepository _companyWebsiteWriteRepository;
    ICompanyWriteRepository _companyWriteRepository;
    ICompanyReadRepository _companyReadRepository;
    IPositionGradeWriteRepository _positionGradeWriteRepository;
    IPositionGradeReadRepository _positionGradeReadRepository;
    ICategoryWriteRepository _categoryWriteRepository;  
    ICategoryReadRepository _categoryReadRepository;
    IJobTypeWriteRepository _jobTypeWriteRepository;
    IJobTypeReadRepository _jobTypeReadRepository;
    IJobLocationWriteRepository _jobLocationWriteRepository;    
    IJobLocationReadRepository _jobLocationReadRepository;
    IRequirementsWriteRepository _requirementsWriteRepository;
    IRequirementReadRepository _requirementReadRepository;
    IPhoneNumberOperatorWriteRepository _operatorWriteRepository;
    IPhoneNumberOperatorReadRepository _operatorReadRepository;
    ICurrencyReadRepository _currencyReadRepository;
    ICurrencyWriteRepository _currencyWriteRepository;
    ISalaryTypeWriteRepository _salaryTypeWriteRepository;
    ISalaryTypeReadRepository _salaryTypeReadRepository;    
    IAnnouncmentSalaryReadRepository _announcmentSalaryReadRepository;
    IAnnouncmentSalaryWriteRepository _announcmentSalaryWriteRepository;
    IUserCookieWriteRepository _userCookieWriteRepository;
    IUserCookieReadRepository _userCookieReadRepository;
    public UnitOfWork(AppDbContext context)
    {
       _context = context; 
    }
    public IAnnouncmentReadRepository AnnouncmentReadRepository => _announcmentReadRepository ?? new AnnouncmentReadRepository(_context);

    public IAnnouncmentWriteRepository AnnouncmentWriteRepository => _announcmentWriteRepository ?? new AnnouncmentWriteRepository(_context);

    public ICompanyLocationReadRepository CompanyLocationReadRepository => _companyLocationReadRepository ?? new CompanyLocationReadRepository(_context);

    public ICompanyLocationWriteRepository CompanyLocationWriteRepository => _companyLocationWriteRepository ?? new CompanyLocationWriteRepository(_context);

    public ICompanyWebsiteReadRepository CompanyWebsiteReadRepository => _companyWebsiteReadRepository ?? new CompanyWebsiteReadRepository(_context);

    public ICompanyWebsiteWriteRepository CompanyWebsiteWriteRepository => _companyWebsiteWriteRepository ?? new CompanyWebsiteWriteRepository(_context);

    public ICompanyReadRepository CompanyReadRepository => _companyReadRepository ?? new CompanyReadRepository(_context);

    public ICompanyWriteRepository CompanyWriteRepository => _companyWriteRepository ?? new CompanyWriteRepository(_context);

    public IPositionGradeReadRepository PositionGradeReadRepository => _positionGradeReadRepository ?? new PositionGradeReadRepository(_context);

    public IPositionGradeWriteRepository PositionGradeWriteRepository => _positionGradeWriteRepository ?? new PositionGradeWriteRepository(_context);

    public ICategoryReadRepository CategoryReadRepository => _categoryReadRepository ?? new CategoryReadRepository(_context);

    public ICategoryWriteRepository CategoryWriteRepository => _categoryWriteRepository ?? new CategoryWriteRepository(_context);

    public IJobTypeReadRepository JobTypeReadRepository => _jobTypeReadRepository ?? new JobTypeReadRepository(_context);

    public IJobTypeWriteRepository JobTypeWriteRepository => _jobTypeWriteRepository ?? new JobTypeWriteRepository(_context);

    public IJobLocationReadRepository JobLocationReadRepository => _jobLocationReadRepository ??  new JobLocationReadRepository(_context);

    public IJobLocationWriteRepository JobLocationWriteRepository => _jobLocationWriteRepository ?? new JobLocationWriteRepository(_context);

    public IRequirementReadRepository RequirementReadRepository => _requirementReadRepository ?? new RequirementsReadRepository(_context);

    public IRequirementsWriteRepository RequirementsWriteRepository => _requirementsWriteRepository ?? new RequirementsWriteRepository(_context);

    public IPhoneNumberOperatorWriteRepository OperatorWriteRepository => _operatorWriteRepository ?? new PhoneNumberOperatorWriteRepository(_context);

    public IPhoneNumberOperatorReadRepository OperatorReadRepository => _operatorReadRepository ?? new PhoneNumberOperatorReadRepository(_context);

    public ICurrencyReadRepository CurrencyReadRepository => _currencyReadRepository ?? new CurrencyReadRepository(_context);

    public ICurrencyWriteRepository CurrencyWriteRepository => _currencyWriteRepository ?? new CurrencyWriteRepository(_context);

    public ISalaryTypeReadRepository SalaryTypeReadRepository => _salaryTypeReadRepository ?? new SalaryTypeReadRepository(_context);

    public ISalaryTypeWriteRepository SalaryTypeWriteRepository => _salaryTypeWriteRepository ?? new SalaryTypeWriteRepository(_context);

    public IAnnouncmentSalaryReadRepository AnnouncmentSalaryReadRepository => _announcmentSalaryReadRepository ?? new AnnouncmentSalaryReadRepository(_context);

    public IAnnouncmentSalaryWriteRepository AnnouncmentSalaryWriteRepository => _announcmentSalaryWriteRepository ?? new AnnouncmentSalaryWriteRepository(_context);

    public IUserCookieReadRepository UserCookieReadRepository => _userCookieReadRepository ?? new UserCookieReadRepository(_context);

    public IUserCookieWriteRepository UserCookieWriteRepository => _userCookieWriteRepository ?? new UserCookieWriteRepository(_context);

    public async Task BeginTransactionAsync()
    {
       await _context.Database.BeginTransactionAsync();
    }
    public async Task RollBackAsync()
    {
       await _context.Database.RollbackTransactionAsync();

    }
    public async Task CommitAsync()
    {
        await _context.Database.CommitTransactionAsync();
    }
    public async Task<int> SaveChangesAsync()
    {
      return  await _context.SaveChangesAsync();
    }
}
