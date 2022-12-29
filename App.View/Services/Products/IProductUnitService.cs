using App.Data.Models;

namespace App.View.Services.Products
{
    public interface IProductUnitService
    {
        Task<List<ProductUnit>> GetAll();
    }
}
