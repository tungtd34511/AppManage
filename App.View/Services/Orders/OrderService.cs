using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Orders
{
    public class OrderService : IOrderService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public OrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Order>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Orders");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Order>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
