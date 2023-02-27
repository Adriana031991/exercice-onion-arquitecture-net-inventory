using FirstWebApi.Entities.Interfaces;
using FirstWebApi.UseCases.CreateProudct;
using FirstWebApi.UseCases.GetProducts;
using FirstWebApi.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApi.UseCases
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
		{

			services.AddTransient<ICreateProductPort, CreateProductIterator>();

			services.AddTransient<IGetProductsInputPort, GetAllProductsIterator>();


			return services;

		}
	}
}
