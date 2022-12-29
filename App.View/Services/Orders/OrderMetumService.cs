using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Orders
{
    public class OrderMetumService : IOrderMetumService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public OrderMetumService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<OrderMetum>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "OrderMetums");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<OrderMetum>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
