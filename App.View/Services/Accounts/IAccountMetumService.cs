using App.Data.Models;

namespace App.View.Services.Accounts
{
    public interface IAccountMetumService
    {
        Task<List<AccountMetum>> GetAll();
    }
}
