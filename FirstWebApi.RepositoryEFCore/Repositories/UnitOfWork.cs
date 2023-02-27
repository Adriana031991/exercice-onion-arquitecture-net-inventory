using FirstWebApi.Entities.Interfaces;
using FirstWebApi.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApi.RepositoryEFCore.Repositories
{
	internal class UnitOfWork : IUnitOfWork
	{
		private readonly FirstWebApiContext context;
		public UnitOfWork(FirstWebApiContext _context)
		{
			context = _context;
		}
		public Task<int> SaveChanges()
		{
			//try
			//{
			return context.SaveChangesAsync();

			//} catch {
			//	return throw new Exception();
			//throw new NotImplementedException();
			//}
		}
	}
}
