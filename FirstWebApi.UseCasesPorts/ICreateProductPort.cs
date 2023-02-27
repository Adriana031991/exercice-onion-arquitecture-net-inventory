using FirstWebApi.DTOs.productsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApi.UseCasesPorts
{
    public interface ICreateProductPort
	{
		Task Handle(CreateProductDto createProductDto);
	}
}
