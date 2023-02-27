using FirstWebApi.DTOs.productsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApi.UseCasesPorts
{
    public interface IGetProductsOutPutPort
	{
		Task Handle(IEnumerable<ProductDto> productsDto);
	}
}
