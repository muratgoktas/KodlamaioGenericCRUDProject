using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGenericCRUDProject.Entities.Concrete
{
    public class Course : BaseEntity<int>
    {
        [ForeignKey("InstructorId")]
        public int InstructorId { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public required string Name { get; set; }

       public  Category? Category { get; set; }
       public  Instructor? Instructor { get; set; }





    }
}
