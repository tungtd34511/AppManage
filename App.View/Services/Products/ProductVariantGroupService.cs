using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Products
{
    public class ProductVariantGroupService : IProductVariantGroupService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public ProductVariantGroupService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ProductVariantGroup>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "ProductVariantGroups");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<ProductVariantGroup>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
