using App.Data.Models;

namespace App.View.Services.Address
{
    public interface IDistrictService
    {
        Task<List<District>> GetAll();
    }
}
