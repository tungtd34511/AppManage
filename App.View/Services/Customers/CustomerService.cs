using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public CustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Customer>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Customers");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Customer>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
