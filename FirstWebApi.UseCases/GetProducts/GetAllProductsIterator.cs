using FirstWebApi.DTOs.productsDtos;
using FirstWebApi.Entities.Interfaces;
using FirstWebApi.Entities.POCOs;
using FirstWebApi.UseCasesPorts;

namespace FirstWebApi.UseCases.GetProducts
{
	internal class GetAllProductsIterator : IGetProductsInputPort
	{
		readonly IEntitiesRepository<Product> repository;
		readonly IGetProductsOutPutPort outPutPort;

		//expression body
		public GetAllProductsIterator(
			IEntitiesRepository<Product> _repository,
			IGetProductsOutPutPort _outPutPort) => (
			repository,  outPutPort) = (
			_repository,  _outPutPort);
		
		public async Task Handle()
		{
			var products = await repository.GetAll();
			var productsDto = products.Select(p=>new ProductDto { Id = p.ProductId, Name =p.ProductName});
			await outPutPort.Handle(productsDto);
			Console.WriteLine(outPutPort.Handle(productsDto));
			return ;
		}
	}
}
