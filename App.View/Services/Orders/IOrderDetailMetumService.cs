using App.Data.Models;

namespace App.View.Services.Orders
{
    public interface IOrderDetailMetumService
    {
        Task<List<OrderDetailMetum>> GetAll();
    }
}
