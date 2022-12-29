using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Accounts
{
    public class AccountService : IAccountService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;

        public AccountService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Account>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Accounts");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Account>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
