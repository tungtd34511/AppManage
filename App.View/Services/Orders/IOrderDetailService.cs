using App.Data.Models;

namespace App.View.Services.Orders
{
    public interface IOrderDetailService
    {
        Task<List<OrderDetail>> GetAll();
    }
}
