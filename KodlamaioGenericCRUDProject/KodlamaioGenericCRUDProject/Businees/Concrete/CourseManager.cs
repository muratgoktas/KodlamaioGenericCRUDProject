 
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

public class CourseManager : ICourseService
{
    private ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course entity)
    {
         _courseDal.Add(entity);
    }

    public void Delete(Course entity)
    {
        _courseDal.Delete(entity);
    }

    public Course Get(Expression<Func<Course, bool>> filter)
    {
        return _courseDal.Get(filter);
    }

    public List<Course> GetAll(Expression<Func<Course, bool>>? filter = null)
    {
        return _courseDal.GetAll(filter);
    }

    public Course Getby(int value)
    {
       return _courseDal.GetbyId(value);
    }

    public void Update(Course entity)
    {
        _courseDal.Update(entity);
    }
}
