using App.Data.Models;

namespace App.View.Services.Warehouses
{
    public interface IWarehouseProductService
    {
        Task<List<WarehouseProduct>> GetAll();
    }
}
