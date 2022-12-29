using App.Data.Models;

namespace App.View.Services.Orders
{
    public interface IOrderTypeService
    {
        Task<List<OrderType>> GetAll();
    }
}
