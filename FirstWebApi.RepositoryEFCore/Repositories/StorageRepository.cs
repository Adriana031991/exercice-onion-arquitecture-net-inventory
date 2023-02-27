

using FirstWebApi.Entities.Interfaces;
using FirstWebApi.Entities.POCOs;
using FirstWebApi.RepositoryEFCore.DataContext;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApi.RepositoryEFCore.Repositories
{
	public class StorageRepository : IEntitiesRepository<Storage>, IStorageRepository
	{
		private readonly FirstWebApiContext Context;

		public StorageRepository(FirstWebApiContext _context)
		{
			Context = _context;
		}

		public Task<Storage> Create(Storage entity)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> Delete(string id)
		{
			var dbStorage = await Context.Storages.FindAsync(id);
			if (dbStorage == null)
			{
				return false;
			}

			Context.Remove(dbStorage);

			return true;
		}

		public async Task<IEnumerable<Storage>> GetAll()
		{
			return await Context.Storages.ToListAsync();
		}

		public async Task<Storage> GetById(string id)
		{
			var dbStorage = await Context.Storages.FindAsync(id);
			if (dbStorage is not null)
			{
				return dbStorage;
			}
			return null;
		}


		public async Task<Storage> Update(string id, Storage entity)
		{
			var dbStorage = await Context.Storages.FindAsync(id);
			if (dbStorage != null)
			{
				dbStorage.LastUpdate = entity.LastUpdate;
				dbStorage.PartialQuantity = entity.PartialQuantity;
				dbStorage.ProductId = entity.ProductId;
				dbStorage.WarehouseId = entity.WarehouseId;
				dbStorage.InputOutputs = entity.InputOutputs;
			}

			return dbStorage;
		}

		public async Task<bool> IsProductInWarehouse(string storageId)
		{
			var storages = await Context.Storages.ToListAsync();
			//var storage = (from s in storages where (s.StorageId == storageId) select s);
			var storage = storages.Where(s => s.StorageId == storageId);

			return storage.Any();
		}

		public async Task<List<Storage?>> StorageListByWarehouse(string idWarehouse)
		{
			var storages = await Context.Storages.ToListAsync();
			//TODO: pendiente revisar

			var a = (from p in storages
					 where p.WarehouseId == idWarehouse
					 select p).ToList();
			foreach (var b in a)
			{

				Console.WriteLine("StorageListByWarehouse " + b.ToString());
			}

			return a;

			//return products
			//		.Include(s => s.Product)
			//		.Include(s => s.Warehouse)
			//		.Where(s => s.WarehouseId == idWarehouse)
			//		.ToList();
		}
	}
}
