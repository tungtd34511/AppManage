using App.Data.Models;

namespace App.View.Services.Products
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
    }
}
