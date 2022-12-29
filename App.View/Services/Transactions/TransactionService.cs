using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Transactions
{
    public class TransactionService : ITransactionService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public TransactionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Transaction>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Transactions");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Transaction>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
