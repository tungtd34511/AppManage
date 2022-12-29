using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace App.View.Services.Accounts
{
    public class AccountMetumService : IAccountMetumService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;

        public AccountMetumService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<AccountMetum>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress+ "AccountMetums");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<AccountMetum>>(stringResponse);
            if(objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
