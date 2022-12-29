using App.Data.Models;
namespace App.View.Services.Accounts
{
    public interface IActivityLogService
    {
        Task<List<ActivityLog>> GetAll();
    }
}
