using App.Data.Models;

namespace App.View.Services.Warehouses
{
    public interface IWarehouseService
    {
        Task<List<Warehouse>> GetAll();
    }
}
