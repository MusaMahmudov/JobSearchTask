using JobSearch.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Domain.Entities;

public class PositionGradeAnnouncment : BaseEntity
{
    public Guid AnnouncmentId { get; set; }
    public Announcment Announcment { get; set; }
    public Guid PositionGradeId { get; set; }
    public PositionGrade PositionGrade { get; set; }
}
