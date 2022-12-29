using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Products
{
    public class ProductVariantService : IProductVariantService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public ProductVariantService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ProductVariant>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "ProductVariants");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<ProductVariant>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
