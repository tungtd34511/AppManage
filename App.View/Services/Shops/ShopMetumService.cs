using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Shops
{
    public class ShopMetumService : IShopMetumService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public ShopMetumService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ShopMetum>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "ShopMetums");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<ShopMetum>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
