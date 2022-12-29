using App.Data.Models;

namespace App.View.Services.Accounts
{
    public interface IAccountService
    {
        Task<List<Account>> GetAll();
    }
}
