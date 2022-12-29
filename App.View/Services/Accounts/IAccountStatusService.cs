using App.Data.Models;

namespace App.View.Services.Accounts
{
    public interface IAccountStatusService
    {
        Task<List<AccountStatus>> GetAll();
    }
}
