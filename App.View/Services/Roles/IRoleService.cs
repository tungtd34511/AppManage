using App.Data.Models;

namespace App.View.Services.Roles
{
    public interface IRoleService
    {
        Task<List<Role>> GetAll();
    }
}
