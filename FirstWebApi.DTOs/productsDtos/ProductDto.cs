using FirstWebApi.DTOs.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApi.DTOs.productsDtos
{
    public class ProductDto
    {
        public string? Id { get; set; }
        public string? Name { get; init; }
        public string? Description { get; set; }

        public int? TotalQuantity { get; set; }

        public string? CategoryId { get; set; }

        public CategoryDto? CategoryDto { get; set; }

    }
}
