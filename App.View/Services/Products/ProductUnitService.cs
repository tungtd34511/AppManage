using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Products
{
    public class ProductUnitService : IProductUnitService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public ProductUnitService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ProductUnit>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "ProductUnits");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<ProductUnit>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
