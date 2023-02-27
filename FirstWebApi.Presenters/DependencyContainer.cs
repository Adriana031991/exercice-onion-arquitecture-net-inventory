using FirstWebApi.Presenters.ProductPresenter;
using FirstWebApi.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApi.Presenters
{
    public static class DependencyContainer
	{
		public static IServiceCollection AddPresenters(
			this IServiceCollection services)
		{
			services.AddScoped<ICreateProductOutPutPort, CreateProductPresenter>();
			services.AddScoped<IGetProductsOutPutPort, GetAllProductsPresenter>();
			return services;
		}
	}
}
