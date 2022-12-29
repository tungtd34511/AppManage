using App.Data.Models;

namespace App.View.Services.Customers
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAll();
    }
}
