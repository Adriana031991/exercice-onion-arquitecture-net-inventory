using FirstWebApi.Entities.Interfaces;
using FirstWebApi.Entities.POCOs;
using FirstWebApi.RepositoryEFCore.DataContext;

namespace FirstWebApi.RepositoryEFCore.Repositories
{
	public class CategoryRepository : IEntitiesRepository<Category>
	{

		private readonly FirstWebApiContext Context;
		public CategoryRepository(FirstWebApiContext _context)
		{
			Context = _context;
		}


		public async Task<Category> Create(Category entity)
		{
			Context.Add(entity);
			return entity;
		}

		public async Task<bool> Delete(string id)
		{
			var dbCategory = await Context.Categories.FindAsync(id);
			if (dbCategory == null)
			{
				return false;
			}

			Context.Remove(dbCategory);

			return true;
		}

		public Task<IEnumerable<Category>> GetAll()
		{
			throw new NotImplementedException();
		}

		public async Task<Category> GetById(string id)
		{
			var dbCategory = await Context.Categories.FindAsync(id);
			return dbCategory;
		}

		public async Task<Category> Update(string id, Category entity)
		{
			var dbCategory = await Context.Categories.FindAsync(id);
			if (dbCategory != null)
			{
				dbCategory.CategoryName = entity.CategoryName;
				dbCategory.Products = entity.Products;


				await Context.SaveChangesAsync();
			}

			return dbCategory;
		}
	}
}
