
namespace FirstWebApi.Entities.Interfaces
{
	public interface IEntitiesRepository<T>
	{

		Task<IEnumerable<T>> GetAll();
		Task<T> GetById(string id);
		Task<T> Create(T entity);
		Task<T> Update(string id, T entity);
		Task<bool> Delete(string id);

	}
}
