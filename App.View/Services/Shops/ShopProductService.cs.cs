using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Shops
{
    public class ShopProductService : IShopProductService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public ShopProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ShopProduct>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "ShopProducts");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<ShopProduct>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
