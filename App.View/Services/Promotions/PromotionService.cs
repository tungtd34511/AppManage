using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Promotions
{
    public class PromotionService : IPromotionService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public PromotionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Promotion>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Promotions");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Promotion>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
