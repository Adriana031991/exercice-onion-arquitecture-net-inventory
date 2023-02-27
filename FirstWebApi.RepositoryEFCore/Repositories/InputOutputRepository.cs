

using FirstWebApi.Entities.Interfaces;
using FirstWebApi.Entities.POCOs;
using FirstWebApi.RepositoryEFCore.DataContext;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApi.RepositoryEFCore.Repositories
{
	public class InputOutputRepository : IEntitiesRepository<InputOutput>
	{
		private readonly FirstWebApiContext Context;
		public InputOutputRepository(FirstWebApiContext _context)
		{
			Context = _context;
		}

		public async Task<InputOutput> Create(InputOutput entity)
		{
			Context.Add(entity);
			return entity;
		}

		public async Task<bool> Delete(string id)
		{
			var dbInputOutput = await Context.InputOutputs.FindAsync(id);
			if (dbInputOutput == null)
			{
				return false;
			}

			Context.Remove(dbInputOutput);

			return true;
		}

		public async Task<IEnumerable<InputOutput>> GetAll()
		{
			return await Context.InputOutputs.ToListAsync();
		}

		public Task<InputOutput> GetById(string id)
		{
			throw new NotImplementedException();
		}

		public async Task<InputOutput> Update(string id, InputOutput entity)
		{
			var dbInputOutput = await Context.InputOutputs.FindAsync(id);
			if (dbInputOutput != null)
			{
				dbInputOutput.InOutDate = entity.InOutDate;
				dbInputOutput.Quantity = entity.Quantity;
				dbInputOutput.IsInput = entity.IsInput;
				dbInputOutput.StorageId = entity.StorageId;
			}

			return dbInputOutput;
		}
	}
}
