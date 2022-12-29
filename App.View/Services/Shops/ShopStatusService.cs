using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Shops
{
    public class ShopStatusService : IShopStatusService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public ShopStatusService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ShopStatus>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "ShopStatus");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<ShopStatus>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
