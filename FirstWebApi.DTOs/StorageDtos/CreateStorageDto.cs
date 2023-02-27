

using FirstWebApi.DTOs.productsDtos;
using FirstWebApi.DTOs.WarehouseDtos;

namespace FirstWebApi.DTOs.StorageDtos
{
	public class CreateStorageDto
	{

		public ProductDto? Product { get; set; }

		public WarehouseDto? Warehouse { get; set; }

	}
}
