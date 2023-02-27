
using FirstWebApi.DTOs.productsDtos;
using FirstWebApi.DTOs.WarehouseDtos;

namespace FirstWebApi.DTOs.StorageDtos
{
	public class StorageDto
	{
		public string StorageId { get; set; }

		public DateTime LastUpdate { get; set; }

		public int PartialQuantity { get; set; }

		public ProductDto? Product { get; set; }

		public WarehouseDto? Warehouse { get; set; }


		//public IEnumerable<InputOutputDto>? InputOutputs { get; set; }
	}
}
