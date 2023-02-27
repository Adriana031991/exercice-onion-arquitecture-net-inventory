using FirstWebApi.DTOs.productsDtos;
using FirstWebApi.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApi.Presenters.ProductPresenter
{
    public class GetAllProductsPresenter : IGetProductsOutPutPort, IPresenter<IEnumerable<ProductDto>>
    {
        public IEnumerable<ProductDto> Content { get; private set; }

        //este convertidor se podria usar en el caso que pidan devolver la informacion en algun formato especifico, por ejemplo xml, o base64 o en cualquier otra cosa
        public Task Handle(IEnumerable<ProductDto> productsDto)
        {
            Content = productsDto;
			return Task.CompletedTask;
        }
    }
}
