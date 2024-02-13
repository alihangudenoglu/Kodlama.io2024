using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

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

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public Category GetById(int id)
    {
        return _categoryDal.Get(x=>x.Id==id);
    }

    public void Update(Category entity)
    {
        _categoryDal.Update(entity);
    }
}
