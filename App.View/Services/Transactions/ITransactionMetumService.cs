using App.Data.Models;

namespace App.View.Services.Transactions
{
    public interface ITransactionMetumService
    {
        Task<List<TransactionMetum>> GetAll();
    }
}
