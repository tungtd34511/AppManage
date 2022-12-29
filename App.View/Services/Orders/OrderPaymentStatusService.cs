using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Orders
{
    public class OrderPaymentStatusService : IOrderPaymentStatusService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public OrderPaymentStatusService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<OrderPaymentStatus>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "OrderPaymentStatus");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<OrderPaymentStatus>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
