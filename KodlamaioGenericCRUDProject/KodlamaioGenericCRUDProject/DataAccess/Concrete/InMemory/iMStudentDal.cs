using KodlamaioGenericCRUDProject.DataAccess.Abstract;
using KodlamaioGenericCRUDProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGenericCRUDProject.DataAccess.Concrete.InMemory;

public class iMStudentDal : IStudentDal
{
    private List<Student> _students;
    public iMStudentDal()
    {
       _students  = new List<Student>
       { 
           new Student {Id=1,FirstName="Murat",LastName="GÖKTAŞ"},
           new Student {Id=2,FirstName="Melike Tuana", LastName="GÖKTAŞ"},
           new Student {Id=3,FirstName="Kayra Deniz",LastName="GÖKTAŞ"},
           new Student {Id=4,FirstName="Birgül",LastName="ÇETİN"}
       };
    }
    public void Add(Student entity)
    {
        _students.Add(entity);  
    }

    public void Delete(Student entity)
    {
        Student deleteRecord = _students.SingleOrDefault(p => p.Id == entity.Id);
        _students.Remove(deleteRecord);
    }

    public Student Get(Expression<Func<Student, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<Student> GetAll(Expression<Func<Student, bool>>? filter = null)
    {
       return _students.ToList();
    }

    public Student GetbyId(int id)
    {
        return _students.SingleOrDefault(p => p.Id == id);
    }

    public void Update(Student entity)
    {
        Student updateRecord =_students.SingleOrDefault(p=>p.Id == entity.Id);
        updateRecord.FirstName = entity.FirstName;
        updateRecord.LastName= entity.LastName;
        _students.Add(updateRecord);

    }
}
