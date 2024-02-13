using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfCategoryDal : EfEntityRepositoryBase<Category, MsSqlContext>, ICategoryDal
{
    public EfCategoryDal(MsSqlContext context) : base(context)
    {
        
    }

}
