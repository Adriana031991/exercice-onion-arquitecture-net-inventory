

using FirstWebApi.Entities.Interfaces;
using FirstWebApi.Entities.POCOs;
using FirstWebApi.RepositoryEFCore.DataContext;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApi.RepositoryEFCore.Repositories
{
	public class WarehouseRepository : IEntitiesRepository<Warehouse>
	{
		private readonly FirstWebApiContext Context;
		public WarehouseRepository(FirstWebApiContext _context)
		{
			Context = _context;
		}
		public Task<Warehouse> Create(Warehouse entity)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> Delete(string id)
		{
			var dbWarehouse = await Context.Warehouses.FindAsync(id);
			if (dbWarehouse == null)
			{
				return false;
			}

			Context.Remove(dbWarehouse);

			return true;
		}

		public async Task<IEnumerable<Warehouse>> GetAll()
		{
			return await Context.Warehouses.ToListAsync();
		}

		public Task<Warehouse> GetById(string id)
		{
			return null;
		}

		public async Task<Warehouse> Update(string id, Warehouse entity)
		{
			var dbWarehouse = await Context.Warehouses.FindAsync(id);
			if (dbWarehouse != null)
			{
				dbWarehouse.WarehouseName = entity.WarehouseName;
				dbWarehouse.WarehouseAddress = entity.WarehouseAddress;
				dbWarehouse.Storages = entity.Storages;
			}

			return dbWarehouse;
		}
	}
}
