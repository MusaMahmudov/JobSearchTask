using JobSearch.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Domain.Entities;

public class PhoneNumber : BaseEntity
{
    public string Number { get; set; }
    public Company Company{ get; set; }
    public Guid CompanyId { get; set; }
    public PhoneNumberOperator PhoneNumberOperator { get; set; }
    public Guid PhoneNumberOperatorId { get; set; }
}
