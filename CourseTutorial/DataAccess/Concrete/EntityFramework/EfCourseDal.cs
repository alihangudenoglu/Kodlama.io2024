using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfCourseDal : EfEntityRepositoryBase<Course, MsSqlContext>, ICourseDal
{
    public EfCourseDal(MsSqlContext context) : base(context)
    {

    }
}
