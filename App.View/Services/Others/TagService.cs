using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Others
{
    public class TagService : ITagService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public TagService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Tag>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Tags");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Tag>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
