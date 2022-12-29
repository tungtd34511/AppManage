using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Transactions
{
    public class TransactionMetumService : ITransactionMetumService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public TransactionMetumService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<TransactionMetum>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "TransactionMetums");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<TransactionMetum>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
