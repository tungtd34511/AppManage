using App.Data.Models;

namespace App.View.Services.Shops
{
    public interface IShopStatusService
    {
        Task<List<ShopStatus>> GetAll();
    }
}
