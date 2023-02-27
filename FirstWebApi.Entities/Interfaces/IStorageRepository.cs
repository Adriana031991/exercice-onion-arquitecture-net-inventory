

using FirstWebApi.Entities.POCOs;

namespace FirstWebApi.Entities.Interfaces
{
	public interface IStorageRepository
	{
		Task<bool> IsProductInWarehouse(string storageId);
		Task<List<Storage?>> StorageListByWarehouse(string idWarehouse);
	}
}
