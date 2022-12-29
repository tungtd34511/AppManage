using App.Data.Models;

namespace App.View.Services.Products
{
    public interface IProductVariantService
    {
        Task<List<ProductVariant>> GetAll();
    }
}
