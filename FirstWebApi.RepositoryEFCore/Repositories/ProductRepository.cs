using FirstWebApi.Entities.Interfaces;
using FirstWebApi.Entities.POCOs;
using FirstWebApi.RepositoryEFCore.DataContext;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApi.RepositoryEFCore.Repositories
{
	public class ProductRepository : IEntitiesRepository<Product>
	{
		private readonly FirstWebApiContext context;
		public ProductRepository(FirstWebApiContext _context)
		{
			context = _context;
		}

		public async Task<Product> Create(Product entity)
		{
			var response =  context.Add(entity).Entity;
			Console.WriteLine("create"+response);
			return response;
			
		}

		public async Task<bool> Delete(string id)
		{
			var dbProduct = await context.Products.FindAsync(id);
			if (dbProduct == null)
			{
				return false;
			}

			context.Remove(dbProduct);
			
			return true;
		}

		public async Task<IEnumerable<Product>> GetAll()
		{
			return await context.Products.ToListAsync();
			//return await context.Products.Include(p => p.Category).ToListAsync();
		}


		public async Task<Product> GetById(string id)
		{
			var dbProduct = await context.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.ProductId == id);
			return dbProduct;
		}

		public async Task<Product> Update(string id, Product entity)
		{
			var dbProduct = await context.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.ProductId == id);
			if (dbProduct != null)
			{
				dbProduct.ProductName = entity.ProductName;
				dbProduct.CategoryId = entity.CategoryId;
				dbProduct.ProductDescription = entity.ProductDescription;
				dbProduct.TotalQuantity = entity.TotalQuantity;
				
			}

			return dbProduct;
		}
	}
}
