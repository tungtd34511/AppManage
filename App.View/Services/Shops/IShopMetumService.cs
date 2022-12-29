using App.Data.Models;

namespace App.View.Services.Shops
{
    public interface IShopMetumService
    {
        Task<List<ShopMetum>> GetAll();
    }
}
