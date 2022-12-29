using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Warehouses
{
    public class WarehouseProductService : IWarehouseProductService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public WarehouseProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<WarehouseProduct>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "WarehouseProducts");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<WarehouseProduct>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
