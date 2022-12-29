using App.Data.Models;

namespace App.View.Services.Address
{
    public interface IProvinceService
    {
        Task<List<Province>> GetAll();
    }
}
