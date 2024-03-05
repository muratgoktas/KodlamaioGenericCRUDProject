using KodlamaioGenericCRUDProject.Entities.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGenericCRUDProject.DataAccess.Abstract
{
    public interface IBaseRepository<T>  where T : class,IEntity //,new()
    { /*  new() ekleyince aşağıdaki hatayı verdi araştır.
       * Severity Code Description Project File Line Suppression State Error CS9040 'Course' cannot satisfy 
       * the 'new()' constraint on parameter 'T' in the generic type or or method 'IBaseRepository<T>' 
       * because 'Course' has required members. KodlamaioGenericCRUDProject 
       * D:\MuratTOOLS\CSharpProjects\KodlamaioGenericCRUDProject\
       * KodlamaioGenericCRUDProject\DataAccess\Abstract\ICourseDal.cs 
       * 12 Active
        */
        List<T> GetAll(Expression<Func<T, bool>>? filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T GetbyId(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
