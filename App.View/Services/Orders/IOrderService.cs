using App.Data.Models;

namespace App.View.Services.Orders
{
    public interface IOrderService
    {
        Task<List<Order>> GetAll();
    }
}
