using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Promotions
{
    public class PromotionMetumService : IPromotionMetumService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public PromotionMetumService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<PromotionMetum>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "PromotionMetums");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<PromotionMetum>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
