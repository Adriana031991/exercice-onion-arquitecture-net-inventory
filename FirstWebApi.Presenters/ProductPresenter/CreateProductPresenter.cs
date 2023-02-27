using FirstWebApi.DTOs.productsDtos;
using FirstWebApi.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApi.Presenters.ProductPresenter
{
    public class CreateProductPresenter : ICreateProductOutPutPort, IPresenter<ProductDto>
    {
        public ProductDto Content { get; private set; }

        //este convertidor se podria usar en el caso que pidan devolver la informacion en algun formato especifico, por ejemplo xml, o base64 o en cualquier otra cosa
        //tomar la informacion que viene en usecases y transformarlo a como se pida
        //no podria usarse en caso de paginación

        public Task Handle(ProductDto productDto)
        {
            Content = productDto;
            return Task.CompletedTask;
        }
    }
}
