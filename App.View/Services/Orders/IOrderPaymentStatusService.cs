using App.Data.Models;

namespace App.View.Services.Orders
{
    public interface IOrderPaymentStatusService
    {
        Task<List<OrderPaymentStatus>> GetAll();
    }
}
