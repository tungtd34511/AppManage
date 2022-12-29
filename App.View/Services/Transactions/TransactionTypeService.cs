using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Transactions
{
    public class TransactionTypeService : ITransactionTypeService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public TransactionTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<TransactionType>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "TransactionTypes");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<TransactionType>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
