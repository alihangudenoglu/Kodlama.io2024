namespace Business.Abstract;

public interface IGenericService<TEntity>
{

    void Add(TEntity entity);
    void Delete(TEntity entity);
    void Update(TEntity entity);
    List<TEntity> GetAll();
    TEntity GetById(int id);
}
