using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Vouchers
{
    public class VoucherStatusService : IVoucherStatusService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public VoucherStatusService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<VoucherStatus>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "VoucherStatus");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<VoucherStatus>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
