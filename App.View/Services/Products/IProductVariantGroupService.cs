using App.Data.Models;

namespace App.View.Services.Products
{
    public interface IProductVariantGroupService
    {
        Task<List<ProductVariantGroup>> GetAll();
    }
}
