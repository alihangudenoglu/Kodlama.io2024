using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public void Add(Course entity)
    {
        _courseDal.Add(entity);
    }

    public void Delete(Course entity)
    {
        _courseDal.Delete(entity);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public Course GetById(int id)
    {
        return _courseDal.Get(x => x.Id == id);
    }

    public void Update(Course entity)
    {
        _courseDal.Update(entity);
    }
}
