using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Accounts
{
    public class ActivityLogService : IActivityLogService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;

        public ActivityLogService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ActivityLog>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "ActivityLogs");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<ActivityLog>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
