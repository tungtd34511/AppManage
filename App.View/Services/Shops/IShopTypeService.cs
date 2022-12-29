using App.Data.Models;

namespace App.View.Services.Shops
{
    public interface IShopTypeService
    {
        Task<List<ShopType>> GetAll();
    }
}
