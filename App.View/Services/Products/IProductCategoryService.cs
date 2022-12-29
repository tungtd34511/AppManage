using App.Data.Models;

namespace App.View.Services.Products
{
    public interface IProductCategoryService
    {
        Task<List<ProductCategory>> GetAll();
    }
}
