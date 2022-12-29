using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Address
{
    public class CountryService : ICountryService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;

        public CountryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Country>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Countries");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Country>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
