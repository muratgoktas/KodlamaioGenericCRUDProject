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

public class StudentManager : IStudentService
{
    private IStudentDal _studentDal;
    public StudentManager(IStudentDal studentDal)
    {
            _studentDal = studentDal;
    }

    public void Add(Student entity)
    {
        _studentDal.Add(entity);
    }

    public void Delete(Student entity)
    {
        _studentDal.Delete(entity);
    }

    public Student Get(Expression<Func<Student, bool>> filter)
    {
       return  _studentDal.Get(filter);
    }

    public List<Student> GetAll(Expression<Func<Student, bool>>? filter = null)
    {
       return  _studentDal.GetAll(filter);
    }

    public Student Getby(int value)
    {
        return _studentDal.GetbyId(value);
    }

    public void Update(Student entity)
    {
        _studentDal.Update(entity);
    }
}
