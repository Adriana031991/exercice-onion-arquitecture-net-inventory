﻿
using System.ComponentModel.DataAnnotations;

namespace FirstWebApi.Entities.POCOs
{
	public class Category
	{
		public string CategoryId { get; set; }
		public string? CategoryName { get; set; }

		//Relación con produtos (ProductEntity)
		public List<Product>? Products { get; set; }

		public override string ToString()
		{
			return $"categoria: {CategoryId}, nombre:{CategoryName}, Products: {Products} ";
		}

		public Category()
		{
		}

		public Category(string categoryId, string categoryName, List<Product>? products)
		{
			CategoryId = categoryId;
			CategoryName = categoryName;
			Products = products;
		}
	}
}
