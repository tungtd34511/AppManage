using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Accounts
{
    public class AccountStatusService : IAccountStatusService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;

        public AccountStatusService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<AccountStatus>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "AccountStatus");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<AccountStatus>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
