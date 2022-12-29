using App.Data.Models;

namespace App.View.Services.Address
{
    public interface ICountryService
    {
        Task<List<Country>> GetAll();
    }
}
