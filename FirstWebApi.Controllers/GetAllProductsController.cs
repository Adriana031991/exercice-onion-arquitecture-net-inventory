using FirstWebApi.DTOs.productsDtos;
using FirstWebApi.Presenters;
using FirstWebApi.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class GetAllProductsController
	{
		readonly IGetProductsInputPort inputPort;
		readonly IGetProductsOutPutPort outputPort;

		public GetAllProductsController(IGetProductsInputPort inputPort, IGetProductsOutPutPort outputPort)
		{
			this.inputPort = inputPort;
			this.outputPort = outputPort;
		}

		[HttpGet]
		public async Task<IEnumerable<ProductDto>> GetAllProducts()
		{
			await inputPort.Handle();
			Console.WriteLine("pasa controller" + ((IPresenter<IEnumerable<ProductDto>>)outputPort).Content);

			return ((IPresenter<IEnumerable<ProductDto>>)outputPort).Content;
		}
	}
}
