using JobSearch.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Domain.Entities;

public class Announcment : BaseEntity
{
    
    public Guid CompanyId { get; set; }
    public Company Company { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public string Position { get; set; }
    public JobType JobType { get; set; }
    public Guid JobTypeId { get; set; }
    public string Overview { get; set; }
    public string JobDescription { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsPremium { get; set; }
    public AnnouncmentSalary? Salary { get; set; }
    public ICollection<Requirements>? Requirements { get; set; }
    public ICollection<FavouriteAnnouncment>? FavouriteAnnouncments { get; set; }
     
    
}
