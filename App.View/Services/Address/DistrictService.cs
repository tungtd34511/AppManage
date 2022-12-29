using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Address
{
    public class DistrictService : IDistrictService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;

        public DistrictService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<District>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Districts");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<District>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
