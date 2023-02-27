using FirstWebApi.Entities.Interfaces;
using FirstWebApi.Entities.POCOs;
using FirstWebApi.RepositoryEFCore.DataContext;
using FirstWebApi.RepositoryEFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApi.RepositoryEFCore
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddRepositories(this IServiceCollection services,
			IConfiguration configuration)
		{

			services.AddDbContext<FirstWebApiContext>(
				options => options.UseSqlServer(configuration.GetConnectionString("FirstWebApi")));

			services.AddScoped<IEntitiesRepository<Product>, ProductRepository>();
			services.AddScoped<IUnitOfWork, UnitOfWork>();

			return services;

		}
	}
}
