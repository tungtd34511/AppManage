using App.Data.Models;

namespace App.View.Services.Promotions
{
    public interface IPromotionMetumService
    {
        Task<List<PromotionMetum>> GetAll();
    }
}
