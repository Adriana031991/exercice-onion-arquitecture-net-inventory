

namespace FirstWebApi.DTOs.productsDtos
{
	public class UpdateProductDto
	{
		public string Name { get; set; }
		public string Description { get; set; }

		public int TotalQuantity { get; set; }

		public string? CategoryId { get; set; }
	}
}
