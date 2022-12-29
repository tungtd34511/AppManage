using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Shops
{
    public class ShopService : IShopService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public ShopService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Shop>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Shops");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Shop>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
