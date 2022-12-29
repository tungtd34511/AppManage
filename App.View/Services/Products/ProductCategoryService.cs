using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Products
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public ProductCategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ProductCategory>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "ProductCategories");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<ProductCategory>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
