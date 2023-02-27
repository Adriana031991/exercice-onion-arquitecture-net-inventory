using FirstWebApi.DTOs.productsDtos;
using FirstWebApi.Presenters;
using FirstWebApi.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
	[ApiController]

	public class CreateProductController
	{
		readonly ICreateProductPort inputPort;
		readonly ICreateProductOutPutPort outputPort;

		public CreateProductController(ICreateProductPort inputPort, ICreateProductOutPutPort outputPort)
		{
			this.inputPort = inputPort;
			this.outputPort = outputPort;
		}

		[HttpPost]
		public async Task<ProductDto> CreateProduct(CreateProductDto product)
		{
			await inputPort.Handle(product);
			Console.WriteLine("pasa controller" + ((IPresenter<ProductDto>)outputPort).Content);
			return ((IPresenter<ProductDto>)outputPort).Content;
		}
	}
}
