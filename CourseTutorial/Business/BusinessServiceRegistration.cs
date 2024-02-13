using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Business.Abstract;
using Business.Concrete;

namespace Business;

public static class BusinessServiceRegistration
{
    public static IServiceCollection AddBusinessService(this IServiceCollection services, IConfiguration configuration)
    {        
        services.AddScoped<IInstructorService, InstructorManager>();
        services.AddScoped<ICourseService, CourseManager>();
        services.AddScoped<ICategoryService, CategoryManager>();
        return services;
    }
}
