using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Product>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Products");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Product>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
