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

public class CategoryManager : ICategoryService
{
    private ICategoryDal _categoryDal;
    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }
    public void Add(Category entity)
    {
        _categoryDal.Add(entity);
    }

    public void Delete(Category entity)
    {
        _categoryDal.Delete(entity);
    }

    public Category Get(Expression<Func<Category, bool>> filter)
    {
        return _categoryDal.Get(filter);
    }

    public List<Category> GetAll(Expression<Func<Category, bool>>? filter = null)
    {
       return  _categoryDal.GetAll(filter);
    }

    public Category Getby(int value)
    {
        return _categoryDal.GetbyId(value);
    }

    public void Update(Category entity)
    {
        _categoryDal.Update(entity);
    }
}
