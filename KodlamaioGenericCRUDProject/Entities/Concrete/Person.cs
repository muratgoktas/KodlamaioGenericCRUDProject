﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGenericCRUDProject.Entities.Concrete
{
    public class Person:BaseEntity<int>
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
    }
}
