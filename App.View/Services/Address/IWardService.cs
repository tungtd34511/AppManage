using App.Data.Models;

namespace App.View.Services.Address
{
    public interface IWardService
    {
        Task<List<Ward>> GetAll();
    }
}
