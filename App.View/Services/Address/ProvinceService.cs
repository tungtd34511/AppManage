using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Address
{
    public class ProvinceService : IProvinceService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;

        public ProvinceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Province>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Provinces");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Province>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
