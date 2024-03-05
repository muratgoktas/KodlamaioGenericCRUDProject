using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGenericCRUDProject.Entities.Concrete;

public class CourseDetail: BaseEntity<int>
{

    [ForeignKey("Course")]
    public int CourseId { get; set; }
    public string? ImageURL { get; set; }
    public string? Description { get; set; }

    // Navigation property
    public required Course Course { get; set; }
} 
