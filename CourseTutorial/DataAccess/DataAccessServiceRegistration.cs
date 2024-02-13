using DataAccess.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace DataAccess;

public static class DataAccessServiceRegistration
{
    public static IServiceCollection AddDataAccessService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<MsSqlContext>(options => options.UseSqlServer(configuration.GetConnectionString("MsSqlConnection")));
        services.AddScoped<IInstructorDal, EfInstructorDal>();
        services.AddScoped<ICourseDal, EfCourseDal>();
        services.AddScoped<ICategoryDal, EfCategoryDal>();
        return services;
    }
}
