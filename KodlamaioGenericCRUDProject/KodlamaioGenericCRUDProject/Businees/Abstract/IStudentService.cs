using KodlamaioGenericCRUDProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGenericCRUDProject.Businees.Abstract
{
    public interface IStudentService:IService,IBaseService<int,Student>
    {
    }
}
