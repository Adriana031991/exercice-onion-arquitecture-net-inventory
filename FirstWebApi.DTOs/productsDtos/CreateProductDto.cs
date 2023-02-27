

namespace FirstWebApi.DTOs.productsDtos
{
    public class CreateProductDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public int? TotalQuantity { get; set; }

        public string? CategoryId { get; set; }

    }
}
