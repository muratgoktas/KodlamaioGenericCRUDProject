using KodlamaioGenericCRUDProject.DataAccess.Abstract;
using KodlamaioGenericCRUDProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGenericCRUDProject.DataAccess.Concrete.InMemory;

public class iMCourseDal : ICourseDal
{


    private List<Course> _courses;
    public iMCourseDal()
    {

        _courses = new List<Course>
        {
            new Course {Id=1, CategoryId=1, InstructorId=1, Name=" 2024 Yazılım Geliştirici Yetiştirme Kampı (C#)"},
            new Course {Id=2, CategoryId=1, InstructorId=2, Name="(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium"},
            new Course {Id=3, CategoryId=1, InstructorId=1, Name="(2022) Yazılım Geliştirici Yetiştirme Kampı (JAVA)"},
            new Course {Id=4, CategoryId=2, InstructorId=1, Name="(2024) Yazılım Geliştirici Yetiştirme Kampı (C#,AI)"}
        };

    }
    public void Add(Course entity)
    {
        _courses.Add(entity);
    }

    public void Delete(Course entity)
    {
        Course _removeRecord = _courses.SingleOrDefault(p => p.Id == entity.Id);
        if (_removeRecord != null)
        {
            _courses.Remove(_removeRecord);
        }
        
    }


    public List<Course> GetAll(Expression<Func<Course, bool>>? filter = null)
    {
        return _courses.ToList();
    }

    public List<Course> GetbyId(int Id)
    {
        return _courses.Where(p => p.Id == Id).ToList();
    }

    public void Update(Course entity)
    {
        Course updateRegister = _courses.SingleOrDefault(p => p.Id == entity.Id);
        updateRegister.CategoryId = entity.CategoryId;
        updateRegister.Name = entity.Name;
        updateRegister.InstructorId = entity.InstructorId;
        _courses.Add(updateRegister);


    }

    //-----------------------------------------------------------------------------------------
    public Course Get(Expression<Func<Course, bool>> filter)
    {
        throw new NotImplementedException();
    }

    Course IBaseRepository<Course>.GetbyId(int id)
    {
        throw new NotImplementedException();
    }
}


