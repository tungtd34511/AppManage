using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Orders
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public OrderDetailService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<OrderDetail>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "OrderDetails");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<OrderDetail>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
