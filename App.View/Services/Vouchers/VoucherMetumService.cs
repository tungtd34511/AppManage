using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Vouchers
{
    public class VoucherMetumService : IVoucherMetumService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public VoucherMetumService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<VoucherMetum>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "VoucherMetums");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<VoucherMetum>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
