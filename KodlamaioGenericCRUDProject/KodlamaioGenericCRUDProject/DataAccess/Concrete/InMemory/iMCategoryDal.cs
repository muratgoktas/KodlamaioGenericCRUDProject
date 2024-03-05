using KodlamaioGenericCRUDProject.DataAccess.Abstract;
using KodlamaioGenericCRUDProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGenericCRUDProject.DataAccess.Concrete.InMemory;

public class iMCategoryDal : ICategoryDal
{
    private List<Category> _categories;
    public iMCategoryDal()
    {
        _categories = new List<Category>
        {
            new Category {Id =1,Name ="Software" },
            new Category {Id =2,Name ="Database"},
            new Category {Id =3,Name ="Other"}
        };
            
    }
    public void Add(Category entity)
    {
        _categories.Add(entity);
    }

    public void Delete(Category entity)
    {
       Category _removeRecord = _categories.SingleOrDefault(p=>p.Id == entity.Id);
        if (_removeRecord != null)
        {
            _categories.Remove(_removeRecord);
        }
    }


    public List<Category> GetAll(Expression<Func<Category, bool>>? filter = null)
    {
        return _categories.ToList();
    }

    public List<Category> GetbyId(int id)
    {
        return _categories.Where(p => p.Id == id).ToList();
    }

    public void Update(Category entity)
    {
        Category _updateRecord=_categories.SingleOrDefault(p=>p.Id == entity.Id);
        _updateRecord.Name= entity.Name;
        _categories.Add(_updateRecord);
        

    }
    //--------------------------------------------------------------------------------------
    public Category Get(Expression<Func<Category, bool>> filter)
    {
        throw new NotImplementedException();

    }

    Category IBaseRepository<Category>.GetbyId(int id)
    {
        throw new NotImplementedException();
    }
}
