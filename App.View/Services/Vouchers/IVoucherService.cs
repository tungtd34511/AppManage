using App.Data.Models;

namespace App.View.Services.Vouchers
{
    public interface IVoucherService
    {
        Task<List<Voucher>> GetAll();
    }
}
