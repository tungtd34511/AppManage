using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Products
{
    public class ProductSizeService : IProductSizeService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public ProductSizeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ProductSize>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "ProductSizes");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<ProductSize>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
