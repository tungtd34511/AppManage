using App.Data.Models;

namespace App.View.Services.Vouchers
{
    public interface IVoucherStatusService
    {
        Task<List<VoucherStatus>> GetAll();
    }
}
