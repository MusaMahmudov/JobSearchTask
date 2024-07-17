using JobSearch.Domain.Entities;
using JobSearch.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace JobSearch.Persistance.Contexts;

public class AppDbContext : DbContext
{
    public List<Announcment> Announcments { get; set; } = null!;
    public List<Company> Companies { get; set; } = null!;
    public List<Category> Categories { get; set; } = null!;
    public List<Currency> Currencies { get; set; } = null!;
    public DbSet<SalaryType> SalaryTypes { get; set; } = null!;
    public DbSet<Requirements> Requirements { get; set; } = null!;
    public DbSet<PositionGrade> PositionGrades { get; set; } = null!;
    public DbSet<PositionGradeAnnouncment> PositionGradeAnnouncments { get; set; } = null!;
    public DbSet<PhoneNumber> PhoneNumbers { get; set; } = null!;
    public DbSet<PhoneNumberOperator> PhoneNumberOperators { get; set; } = null!;
    public DbSet<JobType> JobTypes { get; set; } = null!;
    public DbSet<CompanyLocation> CompanyLocations { get; set; } = null!;
    public DbSet<CompanyWebsite> CompanyWebsites { get; set; } = null!;  
    public DbSet<UserCookies> Cookies { get; set; } = null!;
    public DbSet<FavouriteAnnouncment> FavouriteAnnouncments { get; set; } = null!;
    public DbSet<JobLocationAnnouncment> JobLocationAnnouncments { get; set; } = null!;  
    public DbSet<AnnouncmentSalary> AnnouncmentSalaries { get; set; } = null!;
    public DbSet<JobLocation> JobLocations { get; set; } = null!;
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entities = ChangeTracker.Entries<BaseEntity>();
        foreach (var entity in entities) 
        {
            switch (entity.State) 
            {
              case EntityState.Added:
                    entity.Entity.CreatedAt = DateTime.UtcNow;
                    entity.Entity.CreatedBy = "Admin";
                    entity.Entity.UpdatedAt = DateTime.UtcNow;
                    entity.Entity.UpdatedBy = "Admin";
                    break;
             case EntityState.Modified:
                    entity.Entity.UpdatedBy = "Admin";
                    entity.Entity.UpdatedAt = DateTime.UtcNow;
                    break;

            
            }
        
        }

        return base.SaveChangesAsync(cancellationToken);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       modelBuilder.Entity<AnnouncmentSalary>().HasIndex(s=>s.AnnouncmentId).IsUnique();

        base.OnModelCreating(modelBuilder);
    }
}
