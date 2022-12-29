using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Address
{
    public class WardService : IWardService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;

        public WardService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Ward>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Wards");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Ward>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
