using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Orders
{
    public class OrderDetailMetumService : IOrderDetailMetumService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public OrderDetailMetumService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<OrderDetailMetum>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "OrderDetailMetums");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<OrderDetailMetum>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
