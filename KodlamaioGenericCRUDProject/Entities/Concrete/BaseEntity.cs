using KodlamaioGenericCRUDProject.Entities.Abstruct;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGenericCRUDProject.Entities.Concrete
{
    public class BaseEntity<T>:IEntity
    {
        [Key]
        public required T Id { get; set; }
    }
}
