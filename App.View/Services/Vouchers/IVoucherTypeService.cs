using App.Data.Models;

namespace App.View.Services.Vouchers
{
    public interface IVoucherTypeService
    {
        Task<List<VoucherType>> GetAll();
    }
}
