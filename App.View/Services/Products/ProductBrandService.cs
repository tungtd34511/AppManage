using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Products
{
    public class ProductBrandService : IProductBrandService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public ProductBrandService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ProductBrand>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "ProductBrands");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<ProductBrand>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
