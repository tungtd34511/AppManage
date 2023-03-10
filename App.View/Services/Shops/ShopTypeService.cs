using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Shops
{
    public class ShopTypeService : IShopTypeService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public ShopTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ShopType>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "ShopTypes");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<ShopType>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
