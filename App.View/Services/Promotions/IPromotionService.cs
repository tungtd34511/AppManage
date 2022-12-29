using App.Data.Models;

namespace App.View.Services.Promotions
{
    public interface IPromotionService
    {
        Task<List<Promotion>> GetAll();
    }
}
