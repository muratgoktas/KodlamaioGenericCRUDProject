using KodlamaioGenericCRUDProject.DataAccess.Abstract;
using KodlamaioGenericCRUDProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGenericCRUDProject.DataAccess.Concrete.InMemory;

public class iMInstructorDal : IInstructorDal
{
    private List<Instructor> _instructors;
    public iMInstructorDal()
    {
        _instructors = new List<Instructor> 
        {
            new Instructor {Id=1, FirstName="Engin",LastName="DEMİROĞ",Branch="Software"},
            new Instructor {Id=2, FirstName="Halit Enes",LastName="KALAYCI",Branch="Software"},
            new Instructor {Id=3, FirstName="Ömer Faruk", LastName="ÇOLAKOĞLU",Branch="Database"}

        };
    }
    public void Add(Instructor entity)
    {
        _instructors.Add(entity);
    }

    public void Delete(Instructor entity)
    {
       Instructor deleteRecord = _instructors.SingleOrDefault(p=>p.Id ==entity.Id);
        if (deleteRecord != null)
        {
            _instructors.Remove(entity);
        }
    }

    public Instructor Get(Expression<Func<Instructor, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<Instructor> GetAll(Expression<Func<Instructor, bool>>? filter = null)
    {
        return _instructors.ToList();
    }

    public Instructor GetbyId(int id)
    {
        return _instructors.SingleOrDefault(p => p.Id == id);
    }

    public void Update(Instructor entity)
    {
        Instructor updateRecord = _instructors.SingleOrDefault(predicate => predicate.Id == entity.Id);
        updateRecord.FirstName=entity.FirstName;
        updateRecord.LastName=entity.LastName;
        updateRecord.Branch=entity.Branch;
        _instructors.Add(updateRecord);
    }
}
