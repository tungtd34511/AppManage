using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Vouchers
{
    public class VoucherService : IVoucherService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public VoucherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Voucher>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Vouchers");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Voucher>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
