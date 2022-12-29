using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Accounts
{
    public class PasswordService : IPasswordService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;

        public PasswordService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Password>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Passwords");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Password>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
