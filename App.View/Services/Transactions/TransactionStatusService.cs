using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Transactions
{
    public class TransactionStatusService : ITransactionStatusService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public TransactionStatusService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<TransactionStatus>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "TransactionStatus");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<TransactionStatus>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
