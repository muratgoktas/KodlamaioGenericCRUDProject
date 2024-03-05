using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGenericCRUDProject.Entities.Concrete
{
    public class Category:BaseEntity<int>
    {
        public required string Name { get; set; }
    }
}
