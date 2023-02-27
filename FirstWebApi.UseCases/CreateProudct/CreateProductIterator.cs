using FirstWebApi.DTOs;
using FirstWebApi.DTOs.productsDtos;
using FirstWebApi.Entities.Interfaces;
using FirstWebApi.Entities.POCOs;
using FirstWebApi.UseCasesPorts;

namespace FirstWebApi.UseCases.CreateProudct
{
    public class CreateProductIterator : ICreateProductPort
	{
		readonly IEntitiesRepository<Product> repository;
		readonly IUnitOfWork unitOfWork;
		readonly ICreateProductOutPutPort createProductOutPutPort;

		//expression body
		public CreateProductIterator(
			IEntitiesRepository<Product> _repository,
			IUnitOfWork _unitOfWork,
			ICreateProductOutPutPort _createProductOutPutPort) => (
			repository, unitOfWork, createProductOutPutPort) = (
			_repository, _unitOfWork, _createProductOutPutPort);


		public async Task Handle(CreateProductDto createProductDto)
		{
			Product product = new Product
			{
				ProductId = Guid.NewGuid().ToString(),
				ProductName = createProductDto.Name,
				ProductDescription = createProductDto.Description,
			};
			await repository.Create(product);
			await unitOfWork.SaveChanges();
			await createProductOutPutPort.Handle(
				new ProductDto { Id = product.ProductId, Name = product.ProductName, Description = product.ProductDescription });
		}
	}
}
