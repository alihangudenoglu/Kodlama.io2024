using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework;

public class EfInstructorDal : EfEntityRepositoryBase<Instructor, MsSqlContext>, IInstructorDal
{
    public EfInstructorDal(MsSqlContext context) : base(context)
    {

    }
}
