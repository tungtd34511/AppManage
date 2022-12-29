using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Others
{
    public class TopicService : ITopicService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public TopicService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Topic>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Topics");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Topic>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
