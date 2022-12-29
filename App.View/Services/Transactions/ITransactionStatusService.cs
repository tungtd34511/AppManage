using App.Data.Models;

namespace App.View.Services.Transactions
{
    public interface ITransactionStatusService
    {
        Task<List<TransactionStatus>> GetAll();
    }
}
