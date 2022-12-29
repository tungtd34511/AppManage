using App.Data.Models;

namespace App.View.Services.Transactions
{
    public interface ITransactionTypeService
    {
        Task<List<TransactionType>> GetAll();
    }
}
