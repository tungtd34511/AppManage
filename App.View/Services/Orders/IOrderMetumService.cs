using App.Data.Models;

namespace App.View.Services.Orders
{
    public interface IOrderMetumService
    {
        Task<List<OrderMetum>> GetAll();
    }
}
