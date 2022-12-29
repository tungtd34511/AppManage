using App.Data.Models;

namespace App.View.Services.Vouchers
{
    public interface IVoucherMetumService
    {
        Task<List<VoucherMetum>> GetAll();
    }
}
