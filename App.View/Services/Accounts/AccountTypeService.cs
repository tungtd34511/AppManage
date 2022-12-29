using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Accounts
{
    public class AccountTypeService : IAccountTypeService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;

        public AccountTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<AccountType>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "AccountTypes");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<AccountType>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
