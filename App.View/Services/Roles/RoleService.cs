using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Roles
{
    public class RoleService : IRoleService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public RoleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Role>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Roles");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Role>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
