using App.Data.Models;

namespace App.View.Services.Products
{
    public interface IProductBrandService
    {
        Task<List<ProductBrand>> GetAll();
    }
}
