using App.Data.Models;

namespace App.View.Services.Accounts
{
    public interface IPasswordService
    {
        Task<List<Password>> GetAll();
    }
}
