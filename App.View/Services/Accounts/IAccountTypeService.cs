using App.Data.Models;

namespace App.View.Services.Accounts
{
    public interface IAccountTypeService
    {
        Task<List<AccountType>> GetAll();
    }
}
