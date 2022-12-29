using App.Data.Models;

namespace App.View.Services.Shops
{
    public interface IShopService
    {
        Task<List<Shop>> GetAll();
    }
}
