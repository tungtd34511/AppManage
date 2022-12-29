using App.Data.Models;

namespace App.View.Services.Transactions
{
    public interface ITransactionService
    {
        Task<List<Transaction>> GetAll();
    }
}
