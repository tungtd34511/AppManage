using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Roles
{
    public class RolePermissionService : IRolePermissionService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public RolePermissionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<RolePermission>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "RolePermissions");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<RolePermission>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
