using App.Data.Models;

namespace App.View.Services.Shops
{
    public interface IShopProductService
    {
        Task<List<ShopProduct>> GetAll();
    }
}
