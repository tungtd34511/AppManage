using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Warehouses
{
    public class WarehouseService : IWarehouseService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public WarehouseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Warehouse>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Warehouses");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Warehouse>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
