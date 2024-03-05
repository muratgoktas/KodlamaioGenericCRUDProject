using KodlamaioGenericCRUDProject.Businees.Abstract;
using KodlamaioGenericCRUDProject.DataAccess.Abstract;
using KodlamaioGenericCRUDProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGenericCRUDProject.Businees.Concrete;

public class InstructorManager : IInstructorService
{
    private IInstructorDal _instructorDal;
    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void Add(Instructor entity)
    {
        _instructorDal.Add(entity);
    }

    public void Delete(Instructor entity)
    {
        _instructorDal?.Delete(entity);
    }

    public Instructor Get(Expression<Func<Instructor, bool>> filter)
    {
        return _instructorDal.Get(filter);  
    }

    public List<Instructor> GetAll(Expression<Func<Instructor, bool>>? filter = null)
    {
       return _instructorDal.GetAll(filter);
    }

    public Instructor Getby(int value)
    {
        return _instructorDal.GetbyId(value);
    }

    public void Update(Instructor entity)
    {
        _instructorDal.Update(entity);
    }
}
