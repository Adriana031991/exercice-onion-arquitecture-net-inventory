using FirstWebApi.Presenters;
using FirstWebApi.RepositoryEFCore;
using FirstWebApi.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace FirstWebApi.InverisionControl
{
	public static class DependencyContainer
	{
		//la mision de este proyecto es invertir las dependencias

		public static IServiceCollection AddFirstWebApiDependencies(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddRepositories(configuration);
			services.AddUseCasesServices();
			services.AddPresenters();
			return services;

		}
	}
}
