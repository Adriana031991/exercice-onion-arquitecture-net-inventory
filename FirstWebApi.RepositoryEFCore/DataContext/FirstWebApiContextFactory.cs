using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApi.RepositoryEFCore.DataContext
{
	class FirstWebApiContextFactory : IDesignTimeDbContextFactory<FirstWebApiContext>
	{
		public FirstWebApiContext CreateDbContext(string[] args)
		{
			var OptionsBuilder = new DbContextOptionsBuilder<FirstWebApiContext>();
			OptionsBuilder.UseSqlServer("Data Source=PSOFKA0475;Initial Catalog=InventoryDb1;Integrated Security=true;TrustServerCertificate=True");
			return new FirstWebApiContext(OptionsBuilder.Options);
		}
	}
}
