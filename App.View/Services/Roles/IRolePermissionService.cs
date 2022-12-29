using App.Data.Models;

namespace App.View.Services.Roles
{
    public interface IRolePermissionService
    {
        Task<List<RolePermission>> GetAll();
    }
}
