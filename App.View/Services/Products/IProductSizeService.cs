using App.Data.Models;

namespace App.View.Services.Products
{
    public interface IProductSizeService
    {
        Task<List<ProductSize>> GetAll();
    }
}
